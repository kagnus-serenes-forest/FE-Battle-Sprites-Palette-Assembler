using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyHelpers;

namespace BSPaletteAssembler
{
    partial class BSPaletteAssemblerForm
    {
        #region Palette Table
        public int GetGamePaletteTable()
        {
            return GamePaletteTables[CurrentGame];
        }
        #endregion

        #region Current Visualizer
        public BSPaletteVisualizer GetCurrentVisualizer()
        {
            var CurrentTab = PalettesTabControl.SelectedTab;
            if (CurrentTab == null || CurrentTab.Controls.Empty())
            {
                throw new Exception(CurrentTab == null ?
                    "No tab selected" :
                    "Empty tab selected");
            }
            var paletteViewer = CurrentTab.Controls[0] as BSPaletteVisualizer;
            if (paletteViewer == null)
            {
                throw new Exception("I just don't know what went wrong");
            }
            return paletteViewer;
        }
        #endregion

        #region Palette Compression
        public BSPaletteVisualizer GetPaletteVisualizer(TabPage item)
        {
            if (!item.Controls.Empty())
            {
                return (item.Controls[0] as BSPaletteVisualizer);
            }
            return null;
        }

        public BSPaletteVisualizer CheckPalettesInput(ref int count)
        {
            BSPaletteVisualizer ret = null;
            foreach (TabPage item in PalettesTabControl.TabPages)
            {
                var pv = this.GetPaletteVisualizer(item);
                if (pv != null && pv.ColorsLoaded)
                {
                    ++count;
                    if (ret == null || pv == DefaultPaletteVisualizer)
                    {
                        ret = pv;
                    }
                }
            }
            if (ret != DefaultPaletteVisualizer)
            {
                MsgBoxHelper.Warning("Default palette not set." + Environment.NewLine + "Trying to find another palette to default to.");
            }
            return ret;
        }

        public void GetColors(Control.ControlCollection param, List<Color> pal)
        {
            foreach (BSColorVisualizer item in param)
            {
                pal.Add(item.Current);
            }
        }

        public byte[] CompressPalette()
        {
            int loadedPalettesCount = 0;
            BSPaletteVisualizer paletteViewer = CheckPalettesInput(ref loadedPalettesCount);

            if (loadedPalettesCount == 0)
            {
                MsgBoxHelper.Error("No palette set");
                return null;
            }

            var defaultPalette = new List<Color>();
            GetColors(paletteViewer.Colors, defaultPalette);

            var allPalettes = new List<Color>();
            foreach (TabPage item in PalettesTabControl.TabPages)
            {
                var pv = this.GetPaletteVisualizer(item);
                if (pv != paletteViewer && pv != null && pv.ColorsLoaded)
                {
                    GetColors(pv.Colors, allPalettes);
                }
                else
                {
                    allPalettes.AddRange(defaultPalette);
                }
            }
            var data = Program.PaletteFromColors(allPalettes.ToArray());
            return Program.Compress(data);
        }
        #endregion

        #region NonGBA Save
        public void WriteToFile()
        {
            try
            {
                var data = CompressPalette();
                if (data != null)
                {
                    try
                    {
                        using (var output = File.Open(PathTextBox.Text, FileMode.OpenOrCreate))
                        {
                            output.Position = (long)OffsetSelector.Value;
                            output.Write(data, 0, data.Length);
                        }
                        MsgBoxHelper.Info(string.Format("Wrote data in file {0} at offset 0x{1:X8}", PathTextBox.Text, (int)OffsetSelector.Value));
                    }
                    catch (Exception ex)
                    {
                        MsgBoxHelper.Error("Error with output file: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error(ex.Message);
            }
        }
        #endregion

        #region Change Palette List
        public void ChangePaletteList(string GameName)
        {
            paletteIndexAutoCompleteBehavior.ChangeList(LoadPaletteList(GameName));
        }

        public List<string> LoadPaletteList(string GameName)
        {
            var ret = new List<string>();
            try
            {
                var lines = File.ReadAllLines(GameFileName(GameName));
                foreach (string line in lines)
                {
                    if (line.StartsWith("##FE"))
                    {
                        if (line.TrimStart('#') != GameName)
                        {
                            throw new InvalidGameException();
                        }
                    }
                    else
                    {
                        ret.Add(line);
                    }
                }
            }
            catch (InvalidGameException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error(ex.Message);
            }
            return ret;
        }

        public static string GameFileName(string GameName)
        {
            return Application.StartupPath + Path.DirectorySeparatorChar + "Palette_lists" + Path.DirectorySeparatorChar + GameName + "PaletteList.txt";
        }
        #endregion

        #region Controls Update
        public void UpdateControls()
        {
            paletteEntriesGroupBox.Enabled = IsAROMCkBx.Checked && mCurrentROM.Opened;
            gameGroupBox.Enabled = IsAROMCkBx.Checked;
            FileSaver.Enabled = !IsAROMCkBx.Checked;
            SaveROMButton.Enabled = IsAROMCkBx.Checked && mCurrentROM.Opened && mCurrentROM.Edited;
            SaveROMButton.Enabled = IsAROMCkBx.Checked && mCurrentROM.Opened && mCurrentROM.Edited;
            SaveROMButton.Enabled = IsAROMCkBx.Checked && mCurrentROM.Opened && mCurrentROM.Edited;
            FileSaver.Enabled = OffsetSelector.Enabled = !IsAROMCkBx.Checked && !string.IsNullOrWhiteSpace(PathTextBox.Text);
            exportExtractedIndexButton.Enabled = (ExtractedTab == mTabControl.SelectedTab) && mHasExtracted;
        }
        #endregion

        #region Extract Palette As String
        public string GetExtractedIdx()
        {
            var selectedTab = extractedPaletteTabControl.SelectedTab;
            var visu = GetPaletteVisualizer(selectedTab);

            var l = new List<Color>();
            foreach (BSColorVisualizer col in visu.Colors)
            {
                l.Add(col.Current);
            }

            return Program.PaletteFromColors(l.ToArray()).ToHexString();
        }
        #endregion

        #region Palette Replacement
        public bool ReplaceOldPalette(byte[] NewPal, int PaletteOffset)
        {
            if (mCurrentROM == null)
            {
                throw new NoROMException();
            }
            int oldsize = mCurrentROM.LZ77CompressedDataLength(PaletteOffset);
            if (NewPal.Length > oldsize)
            {
                return false;
            }
            mCurrentROM.InsertData(PaletteOffset, NewPal);
            return true;
        }
        #endregion

        #region Palette Extraction
        public void ExtractPaletteFromROM()
        {
            if (mCurrentROM.Opened)
            {
                int palOffset = GetPaletteOffset();
                if (palOffset == 0)
                {
                    return;
                }
                byte[] palette = mCurrentROM.DecompressLZ77CompressedData(palOffset);
                if (palette != null)
                {
                    for (int i = 0; i < 5; ++i)
                    {
                        byte[] tmp = new byte[32];
                        Array.Copy(palette, i * 32, tmp, 0, 32);
                        visualizers[i].LoadColors(Program.PaletteToColors(tmp));
                    }
                    mTabControl.SelectedTab = ExtractedTab;
                    PaletteEntrySelector.Focus();
                }
                else
                {
                    MsgBoxHelper.Error("Couldn't extract palette entry");
                }
            }
            else
            {
                MsgBoxHelper.Error("You must select a ROM");
            }
        }
        #endregion

        #region Palette Offset and Ptr
        public int GetPaletteOffset()
        {
            int paletteEntry = PaletteEntrySelector.SelectedIndex;
            if (paletteEntry == 0)
            {
                return 0;
            }
            int gamePaletteTable = GetGamePaletteTable();
            return mCurrentROM.ReadPointer(gamePaletteTable + (paletteEntry * 16));
        }

        public int GetOffsetPtr()
        {
            int paletteEntry = PaletteEntrySelector.SelectedIndex;
            if (paletteEntry == 0)
            {
                throw new Exception("Invalid entry");
            }
            int gamePaletteTable = GetGamePaletteTable();
            return gamePaletteTable + (paletteEntry * 16);
        }
        #endregion
    }
}
