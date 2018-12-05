using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSPaletteAssembler
{
    class InvalidGameException : Exception
    {
        public InvalidGameException() : base("") { }
    }
}
