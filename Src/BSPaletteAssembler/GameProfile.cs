using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using MyHelpers;

namespace BSPaletteAssembler
{
    // Plan for next release
    public class GameProfile
    {
        private static readonly Dictionary<String, int> DefaultPalettePtrTableDictionary = new Dictionary<string, int>
        {
            {"FE6", 0x7FC004},
            {"FE7", 0xFD8004},
            {"FE8", 0xEF8004}
        };

        #region Properties

        public int PaletteTableOffset
        {
            get;
            private set;
        }

        public List<String> PaletteEntriesList
        {
            get;
            private set;
        }

        public String BaseGame
        {
            get;
            private set;
        }

        #endregion

        #region Ctor
        
        public GameProfile(String file)
        {
            ReadProfile(file);
        }

        #endregion

        #region Methods

        #region Public Methods

        public void Check()
        {
            var hasError = false;
            String errorStr = null;

            if (PaletteEntriesList.Empty())
            {
                errorStr = "Empty list";
                hasError = true;
            }

            if (BaseGame == null)
            {
                if (String.IsNullOrEmpty(errorStr))
                {
                    errorStr = "Base game not set";
                    hasError = true;
                }
                else
                {
                    errorStr += ", base game not set";
                }
            }

            if (PaletteTableOffset == 0)
            {
                if (String.IsNullOrEmpty(errorStr))
                {
                    errorStr = "Can't get palette table offset";
                    hasError = true;
                }
                else
                {
                    errorStr += " and can't get palette table offset";
                }
            }

            if (hasError)
            {
                throw new Exception(errorStr);
            }
        }

        #endregion
        #region Private Methods

        private void ReadProfile(String file)
        {
            try
            {
                var lines = File.ReadAllLines(file);
                PaletteEntriesList = new List<String>();
                PaletteTableOffset = 0;
                BaseGame = null;
                foreach (String line in lines)
                {
                    if (line.Trim().StartsWith("##FE"))
                    {
                        BaseGame = line.Trim().Trim('#').ToUpper();
                        if (PaletteTableOffset == 0)
                        {
                            PaletteTableOffset = DefaultPalettePtrTableDictionary[BaseGame];
                        }
                    }
                    else if (line.Trim().StartsWith("#@"))
                    // For cases where the palette table has been repointed.
                    // Like expanding FE6 palette ptr table
                    {
                        var l = line.Trim().Substring(2);
                        if (l.Trim().StartsWith("0x"))
                        {
                            l = l.Trim().Substring(2);
                        }
                        try
                        {
                            PaletteTableOffset = int.Parse(l, NumberStyles.HexNumber) & 0x01FFFFFF;
                        }
                        catch (Exception ex)
                        {
                            MsgBoxHelper.Error("Error with new table offset: " + ex.Message);
                        }
                    }
                    else if (!line.Trim().StartsWith("#"))
                    {
                        PaletteEntriesList.Add(line.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBoxHelper.Error(ex.Message);
            }
        }

        #endregion

        #endregion
    }
}
