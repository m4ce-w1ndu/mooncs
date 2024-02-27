using System;
using System.Reflection;

namespace AGCCore.Core
{
    /// <summary>
    /// C# implementation of a bitfield struct attribute
    /// </summary>
    public sealed class BitfieldLengthAttribute : Attribute
    {
        public uint Length { get; init; }

        public BitfieldLengthAttribute(uint length)
        {
            Length = length;
        }
    }

    internal class ConversionUtility
    {
        /// <summary>
        /// Converts a bitfield struct value to long
        /// </summary>
        public static long ToLong<T>(T t) where T: struct
        {
            long result = 0;
            int offset = 0;

            foreach (var field in t.GetType().GetFields())
            {
                var attrs = field.GetCustomAttributes(typeof(BitfieldLengthAttribute), false);
                if (attrs.Length == 1)
                {
                    var fieldLength = ((BitfieldLengthAttribute)attrs[0]).Length;
                    long mask = 0;
                    for (int i = 0; i < fieldLength; i++)
                        mask |= 1 << i;

                    result |= ((uint)field.GetValue(t) & mask) << offset;

                    offset += (int)fieldLength;
                }
            }

            return result;
        }
    }
}