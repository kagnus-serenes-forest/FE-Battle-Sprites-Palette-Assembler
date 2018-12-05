using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MyHelpers;

namespace BSPaletteAssembler
{
    public static class GameProfileLoader
    {
        public static List<GameProfile> Load()
        {
            // Loads default profiles
            var ret = new List<GameProfile>
            {
                new GameProfile(Application.StartupPath + Path.DirectorySeparatorChar + "Palette_lists" + Path.DirectorySeparatorChar +
                    "FE6PaletteList.txt"),
                new GameProfile(Application.StartupPath + Path.DirectorySeparatorChar + "Palette_lists" + Path.DirectorySeparatorChar +
                    "FE7PaletteList.txt"),
                new GameProfile(Application.StartupPath + Path.DirectorySeparatorChar + "Palette_lists" + Path.DirectorySeparatorChar +
                    "FE8PaletteList.txt")
            };

            // Loads custom profiles
            foreach (String filename in Directory.GetFiles(Application.StartupPath + Path.DirectorySeparatorChar + "Profiles", "*.txt"))
            {
                try
                {
                    var profile = new GameProfile(filename);
                    profile.Check();
                    ret.Add(profile);
                }
                catch (Exception ex)
                {
                    MsgBoxHelper.Error(filename + " is an invalid game profile: " + ex.Message);
                }
            }
            return ret;
        }
    }
}
