using System;

namespace AGCCore.Core
{
    public sealed class BitfieldLengthAttribute : Attribute
    {
        public uint Length { get; init; }

        public BitfieldLengthAttribute(uint length)
        {
            Length = length;
        }
    }
}