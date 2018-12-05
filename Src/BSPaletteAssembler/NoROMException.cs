using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPaletteAssembler
{
    /// <summary>
    /// No ROM was selected by the user
    /// </summary>
    public class NoROMException : Exception
    {
        public NoROMException() : base("No output ROM selected") { }
    }
}
