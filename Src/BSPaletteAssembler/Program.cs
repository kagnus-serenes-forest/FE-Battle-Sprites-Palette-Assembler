using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Nintenlord.ROMHacking.GBA.Graphics;
using System.Drawing;

// Look at GBAPalette from GBACore
// byte[] GBAPalette.toRawGBAPalette(Color[]);

namespace BSPaletteAssembler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BSPaletteAssemblerForm());
        }

        public static Color[] PaletteToColors(byte[] palette)
        {
            return GBAPalette.ToPalette(palette, 0, palette.Length >> 1);
        }

        public static byte[] PaletteFromColors(Color[] palette)
        {
            return GBAPalette.toRawGBAPalette(palette);
        }

        public static byte[] Compress(byte[] data)
        {
            return Nintenlord.ROMHacking.GBA.Compressions.LZ77.Compress(data);
        }
    }
}
