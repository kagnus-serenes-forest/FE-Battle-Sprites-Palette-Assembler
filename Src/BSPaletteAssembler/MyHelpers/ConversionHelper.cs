using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyHelpers
{
    public static class ConversionHelper
    {
        /// <summary>
        /// Converts an Array of one type to an Array of another type.
        /// The returned Array will have the same length than the given array
        /// </summary>
        /// <typeparam name="InType">The type to convert from</typeparam>
        /// <typeparam name="OutType">The type to convert to</typeparam>
        /// <param name="Arr">The Array to convert</param>
        /// <param name="Converter">The converter</param>
        /// <returns>A converted Array</returns>
        public static OutType[] ConvertEach<InType, OutType>(this InType[] Arr, Func<InType, OutType> Converter)
        {
            int max = Arr.Length;
            var ret = new OutType[max];
            for (int i = 0; i < max; ++i)
            {
                ret[i] = Converter(Arr[i]);
            }
            return ret;
        }

        /// <summary>
        /// Converts an Array of one type to an Array of another type.
        /// Converts each element into multiple elements of the other type
        /// </summary>
        /// <typeparam name="InType">The type to convert from</typeparam>
        /// <typeparam name="OutType">The type to convert to</typeparam>
        /// <param name="Arr">The Array to convert</param>
        /// <param name="Converter">The converter</param>
        /// <returns>A converted Array</returns>
        public static OutType[] ConvertSplit<InType, OutType>(this InType[] Arr, Func<InType, OutType[]> Converter)
        {
            var ret = new List<OutType>(Arr.Length);
            foreach (InType item in Arr)
            {
                ret.AddRange(Converter(item));
            }
            return ret.ToArray();
        }

        /// <summary>
        /// Converts an Array of one type to an Array of another type.
        /// Merges n elements of type T into an element of type U.
        /// </summary>
        /// <typeparam name="InType">The type to convert from</typeparam>
        /// <typeparam name="OutType">The type to convert to</typeparam>
        /// <param name="Arr">The Array to convert</param>
        /// <param name="Converter">The converter</param>
        /// <returns>A converted Array</returns>
        public static OutType[] ConvertMerge<InType, OutType>(this InType[] Arr, Func<InType, List<InType>, List<OutType>, bool> Converter)
        {
            var ret = new List<OutType>(Arr.Length);
            var buffer = new List<InType>();
            foreach (InType item in Arr)
            {
                if (Converter(item, buffer, ret))
                {
                    buffer.Clear();
                }
            }
            if (buffer.Empty() == false)
            {
                throw new ArgumentException("Invalid data");
            }
            return ret.ToArray();
        }

        /// <summary>
        /// Converts a Byte Array to a String
        /// </summary>
        /// <param name="Bytes">The byte Array</param>
        /// <returns>A String containing the untouched bytes</returns>
        public static String ToString(this Byte[] Bytes)
        {
            return new String(Bytes.ConvertEach<Byte, Char>(x => (Char)x));
        }

        /// <summary>
        /// Converts a byte Array to a printable hexadecimal representation.
        /// </summary>
        /// <param name="Bytes">The byte Array</param>
        /// <returns>A printable String</returns>
        public static String ToHexString(this Byte[] Bytes)
        {
            var ret = "";
            foreach (Byte b in Bytes)
            {
                ret = String.Concat(ret, b.ToString("X2"));
            }
            return ret;
        }

        /// <summary>
        /// Converts an UInt16 Array into a Byte Array.
        /// </summary>
        /// <param name="Arr">The UInt16 Array</param>
        /// <returns> Byte Array</returns>
        public static Byte[] Bytes(this UInt16[] Arr)
        {
            return Arr.ConvertSplit<UInt16, Byte>(s => BitConverter.GetBytes(s));
        }

        public static UInt16[] ToUShorts(this Byte[] Arr)
        {
            return Arr.ConvertMerge<Byte, UInt16>((b, bl, usl) =>
            {
                bl.Add(b);
                if (bl.Count == 2)
                {
                    usl.Add(BitConverter.ToUInt16(bl.ToArray(), 0));
                    return true;
                }
                return false;
            });
        }

        public static Byte[] ToBytes(this String s)
        {
            return s.ToCharArray().ConvertMerge<Char, Byte>(
                (c, cl, bl) =>
                {
                    cl.Add(c);
                    if (cl.Count == 2)
                    {
                        bl.Add(Byte.Parse(new string(cl.ToArray()), System.Globalization.NumberStyles.AllowHexSpecifier));
                        return true;
                    }
                    return false;
                }
                );
        }
    }
}
