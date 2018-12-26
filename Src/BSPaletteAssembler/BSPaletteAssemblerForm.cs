using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MyHelpers;

namespace BSPaletteAssembler
{
    public partial class BSPaletteAssemblerForm : Form
    {
        #region Properties
        #endregion

        #region Fields
        private OpenFileDialog mOfd = new OpenFileDialog()
        {
            CheckFileExists = true,
            CheckPathExists = true,
            Filter = ofdGBAFilter,
            Title = "Choose one file",
            Multiselect = false
        };

        private BSPaletteVisualizer[] visualizers;
        private Dictionary<RadioButton, int> GamePaletteTables;
        private RadioButton CurrentGame;

        private BSPaletteVisualizer DefaultPaletteVisualizer;

        private Nintenlord.ROMHacking.GBA.GBAROM mCurrentROM = new Nintenlord.ROMHacking.GBA.GBAROM();
        private static string ofdGBAFilter = "GBA files|*.gba";
        private static string ofdAllFilter = "All files|*";
        private bool mHasExtracted = false;
        private PaletteIndexAutoCompleteBehavior paletteIndexAutoCompleteBehavior;

        #endregion

        #region Constructor
        public BSPaletteAssemblerForm()
        {
            InitializeComponent();
            DefaultPaletteVisualizer = PlayerPaletteVisualizer;
            paletteIndexAutoCompleteBehavior = new PaletteIndexAutoCompleteBehavior(PaletteEntrySelector);
            CurrentGame = FE7Radio;
            ChangePaletteList("FE7");
            GamePaletteTables = new Dictionary<RadioButton, int>
            {
                { FE7Radio, 0xFD8004 },
                { FE6Radio, 0x7FC004 },
                { FE8Radio, 0xEF8004 }
            };
            visualizers = new BSPaletteVisualizer[]
            {
                extractedPlayerVisu,
                extractedEnemyVisu,
                extractedNpcVisu,
                extractedPlayer4LAVisu,
                extractedPlayer1LAVisu
            };
        }
        #endregion

        #region Event Handlers

        #region Clipboard Buttons
        private void ClipboardImporter_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                var sdata = Clipboard.GetText();
                try
                {
                    var data = sdata.ToBytes();
                    var paletteViewer = GetCurrentVisualizer();
                    var colors = Program.PaletteToColors(data);
                    paletteViewer.LoadColors(colors);
                    mTabControl.SelectedTab = ImportedTab;
                }
                catch (ArgumentException ex)
                {
                    MsgBoxHelper.Error(ex.Message);
                }
                catch (Exception ex)
                {
                    MsgBoxHelper.Error("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        private void ClipboardExporter_Click(object sender, EventArgs e)
        {
            try
            {
                var data = CompressPalette();
                if (data != null)
                {
                    var s = data.ToHexString();
                    Clipboard.SetText(s);
                    MessageBox.Show(s);
                }
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error("An unexpected error occurred: " + ex.Message);
            }
        }

        private void ExportExtractedIndexButton_Click(object sender, EventArgs e)
        {
            string idx;
            try
            {
                idx = GetExtractedIdx();
                Clipboard.SetText(idx);
                MsgBoxHelper.Info(idx);
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error(ex.Message);
            }
        }

        #endregion

        #region Save Changes Event Handlers
        private void FileSaver_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PathTextBox.Text))
            {
                var rdonly = OffsetSelector.ReadOnly;
                OffsetSelector.ReadOnly = true;
                WriteToFile();
                this.Text = "FE BSPalette Assembler";
                OffsetSelector.ReadOnly = rdonly;
            }
        }

        private void SaveROMButton_Click(object sender, EventArgs e)
        {
            if (mCurrentROM.Opened)
            {
                mCurrentROM.SaveROM();
                UpdateControls();
            }
        }
        #endregion

        #region Reset Buttons
        private void ResetCurrentPalette_Click(object sender, EventArgs e)
        {
            try
            {
                var currentPalette = GetCurrentVisualizer();
                currentPalette.UnloadColors();
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error(ex.Message);
            }
        }

        private void ResetAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage item in PalettesTabControl.TabPages)
            {
                var pv = this.GetPaletteVisualizer(item);
                pv.UnloadColors();
            }
        }
        #endregion

        #region Output File
        private void GetOutputFile_Click(object sender, EventArgs e)
        {
            if (mCurrentROM.Opened && mCurrentROM.Edited)
            {
                if (MsgBoxHelper.AskYesNoQuestion("Do you want to save your edits to the ROM ?"))
                {
                    mCurrentROM.SaveROM();
                }
                autoExtractCheckBox.Checked = false;
                mCurrentROM.CloseROM();
            }
            if (mOfd.ShowDialog() == DialogResult.OK && mOfd.FileNames.Length > 0)
            {
                PathTextBox.Text = mOfd.FileName;
                if (IsAROMCkBx.Checked)
                {
                    mCurrentROM.OpenROM(PathTextBox.Text);
                }
                UpdateControls();
                mOfd.InitialDirectory = Path.GetDirectoryName(mOfd.FileName);
            }
        }
        #endregion

        #region Default Palette
        private void defaultPaletteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DefaultPaletteVisualizer = GetCurrentVisualizer();
                currentDefaultPaletteNameLabel.Text = PalettesTabControl.SelectedTab.Text;
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error(ex.Message);
            }
        }
        #endregion

        #region Changes
        private void IsAROMCkBx_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
            mOfd.CheckFileExists = IsAROMCkBx.Checked;
            mOfd.Filter = IsAROMCkBx.Checked ? ofdGBAFilter : ofdAllFilter;
        }

        private void SelectedGameChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton Sender && Sender.Checked)
            {
                CurrentGame = Sender;
                autoExtractCheckBox.Checked = false;
                ChangePaletteList(Sender.Text);
            }
        }

        private void AutoExtractCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                PaletteEntrySelector.SelectedIndexChanged += PaletteEntrySelector_SelectedIndexChanged;
            }
            else
            {
                PaletteEntrySelector.SelectedIndexChanged -= PaletteEntrySelector_SelectedIndexChanged;
            }
        }

        private void PaletteEntrySelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExtractPaletteFromROM();
            mHasExtracted = true;
            UpdateControls();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            UpdateControls();
        }
        #endregion

        #region Insertion Event

        private void InsertEntryButton_Click(object sender, EventArgs e)
        {
            // Get palette offset
            int offset = GetPaletteOffset();
            byte[] palette = CompressPalette();

            if (palette == null) { return; }

            //TODO:
            // Try to insert and offer to repoint if necessary
            if (ReplaceOldPalette(palette, offset))
            {
                MsgBoxHelper.Info("Inserted palette, changes won't be effective until you click \"Save ROM\"");
            }
            else
            {
                int offsetPtr;
                try
                {
                    offsetPtr = GetOffsetPtr();
                }
                catch (Exception ex)
                {
                    MsgBoxHelper.Error(ex.Message);
                    return;
                }
                using (var rf = new RepointingForm(mCurrentROM, offsetPtr, palette))
                {
                    rf.ShowDialog(this);
                }
                MsgBoxHelper.Info("Inserted and repointed palette, changes won't be effective until you click \"Save ROM\"");
            }
            UpdateControls();
        }

        #endregion

        #region Extraction Event

        private void extractEntryButton_Click(object sender, EventArgs e)
        {
            ExtractPaletteFromROM();
            mHasExtracted = true;
            UpdateControls();
        }
        #endregion

        #endregion

        #region Misc

        //private int GetGamePaletteTable()
        //{
        //    return GamePaletteTables[CurrentGame];
        //}

        //private BSPaletteVisualizer GetCurrentVisualizer()
        //{
        //    var CurrentTab = PalettesTabControl.SelectedTab;
        //    if (CurrentTab == null || CurrentTab.Controls.Empty())
        //    {
        //        throw new Exception(CurrentTab == null ?
        //            "No tab selected" :
        //            "Empty tab selected");
        //    }
        //    var paletteViewer = CurrentTab.Controls[0] as BSPaletteVisualizer;
        //    if (paletteViewer == null)
        //    {
        //        throw new Exception("I just don't know what went wrong");
        //    }
        //    return paletteViewer;
        //}

        //private BSPaletteVisualizer GetPaletteVisualizer(TabPage item)
        //{
        //    if (!item.Controls.Empty())
        //    {
        //        return (item.Controls[0] as BSPaletteVisualizer);
        //    }
        //    return null;
        //}

        //private BSPaletteVisualizer CheckPalettesInput(ref int count)
        //{
        //    BSPaletteVisualizer ret = null;
        //    foreach (TabPage item in PalettesTabControl.TabPages)
        //    {
        //        var pv = this.GetPaletteVisualizer(item);
        //        if (pv != null && pv.ColorsLoaded)
        //        {
        //            ++count;
        //            if (ret == null || pv == DefaultPaletteVisualizer)
        //            {
        //                ret = pv;
        //            }
        //        }
        //    }
        //    if (ret != DefaultPaletteVisualizer)
        //    {
        //        MsgBoxHelper.Warning("Default palette not set." + Environment.NewLine + "Trying to find another palette to default to.");
        //    }
        //    return ret;
        //}

        //private void GetColors(Control.ControlCollection param, List<Color> pal)
        //{
        //    foreach (BSColorVisualizer item in param)
        //    {
        //        pal.Add(item.Current);
        //    }
        //}

        //private Byte[] CompressPalette()
        //{
        //    int loadedPalettesCount = 0;
        //    BSPaletteVisualizer paletteViewer = CheckPalettesInput(ref loadedPalettesCount);

        //    if (loadedPalettesCount == 0)
        //    {
        //        MsgBoxHelper.Error("No palette set");
        //        return null;
        //    }

        //    var defaultPalette = new List<Color>();
        //    GetColors(paletteViewer.Colors, defaultPalette);

        //    var allPalettes = new List<Color>();
        //    foreach (TabPage item in PalettesTabControl.TabPages)
        //    {
        //        var pv = this.GetPaletteVisualizer(item);
        //        if (pv != paletteViewer && pv != null && pv.ColorsLoaded)
        //        {
        //            GetColors(pv.Colors, allPalettes);
        //        }
        //        else
        //        {
        //            allPalettes.AddRange(defaultPalette);
        //        }
        //    }
        //    var data = Program.PaletteFromColors(allPalettes.ToArray());
        //    return Program.Compress(data);
        //}

        //private void WriteToFile()
        //{
        //    try
        //    {
        //        var data = CompressPalette();
        //        if (data != null)
        //        {
        //            try
        //            {
        //                using (var output = File.Open(PathTextBox.Text, FileMode.OpenOrCreate))
        //                {
        //                    output.Position = (long)OffsetSelector.Value;
        //                    output.Write(data, 0, data.Length);
        //                }
        //                MsgBoxHelper.Info(String.Format("Wrote data in file {0} at offset 0x{1:X8}", PathTextBox.Text, (int)OffsetSelector.Value));
        //            }
        //            catch (Exception ex)
        //            {
        //                MsgBoxHelper.Error("Error with output file: " + ex.Message);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MsgBoxHelper.Error(ex.Message);
        //    }
        //}

        //private void ChangePaletteList(String GameName)
        //{
        //    PaletteEntrySelector.DataSource = LoadPaletteList(GameName);
        //}

        //private List<String> LoadPaletteList(String GameName)
        //{
        //    var ret = new List<String>();
        //    try
        //    {
        //        var lines = File.ReadAllLines(GameFileName(GameName));
        //        foreach (String line in lines)
        //        {
        //            if (line.StartsWith("##FE"))
        //            {
        //                if (line.TrimStart('#') != GameName)
        //                {
        //                    throw new InvalidGameException();
        //                }
        //            }
        //            else
        //            {
        //                ret.Add(line);
        //            }
        //        }
        //    }
        //    catch (InvalidGameException)
        //    {
        //        throw;
        //    }
        //    catch (Exception ex)
        //    {
        //        MsgBoxHelper.Error(ex.Message);
        //    }
        //    return ret;
        //}

        //private String GameFileName(String GameName)
        //{
        //    return Application.StartupPath + Path.DirectorySeparatorChar + "Palette_lists" + Path.DirectorySeparatorChar + GameName + "PaletteList.txt";
        //}

        //private void UpdateControls()
        //{
        //    paletteEntriesGroupBox.Enabled = IsAROMCkBx.Checked && mCurrentROM.Opened;
        //    gameGroupBox.Enabled = IsAROMCkBx.Checked;// && mCurrentROM.Opened;
        //    FileSaver.Enabled = !IsAROMCkBx.Checked;
        //    SaveROMButton.Enabled = IsAROMCkBx.Checked && mCurrentROM.Opened && mCurrentROM.Edited;
        //    FileSaver.Enabled = OffsetSelector.Enabled = !IsAROMCkBx.Checked && !String.IsNullOrWhiteSpace(PathTextBox.Text);
        //    exportExtractedIndexButton.Enabled = (ExtractedTab == mTabControl.SelectedTab) && mHasExtracted;
        //}
        #endregion
    }
}
