using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyHelpers
{
    public static class MiscHelpers
    {
        public static bool Empty(this IList l)
        {
            return l.Count == 0;
        }
    }
}
