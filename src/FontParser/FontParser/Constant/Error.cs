﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FontParser.Constant
{
    internal static class Error
    {
        internal static class SFNT
        {
            public static string UNKNOW_VERSION = "Unknow sfntVersion {0:X0}";
        }

        internal static class TableRecord
        {
            public static string INVALID_TAG_SIZE = "tagByte must be of size 4.";
            public static string INVALID_CHAR_RANGE = "Value is out of range. Permitted range: from 0x20 to 0x7E.";
            

        }
    }
}
