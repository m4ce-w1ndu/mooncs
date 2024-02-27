namespace AGCCore.Symbols
{
    /// <summary>
    /// Symbols parameters and constants
    /// </summary>
    public static class SymbolsParams
    {
        /// <summary>
        /// Maximum length of a filesystem path.
        /// </summary>
        public static const int MAX_PATH_LENGTH = 1024;

        /// <summary>
        /// Maximum length of a file name.
        /// </summary>
        public static const inst MAX_FILE_LENGTH = 256;

        /// <summary>
        /// Maximum length of a label.
        /// </summary>
        public static const int MAX_LABEL_LENGTH = 10;

        /// <summary>
        /// Maximum length of a single line.
        /// </summary>
        public static const int MAX_LINE_LENGTH = 132;
    
        /// <summary>
        /// Maximum length of a piece of source code.
        /// </summary>
        public static const int MAX_LIST_LENGTH = 10;

        /// <summary>
        /// Maximum number of source files.
        /// </summary>
        public static const int MAX_SOURCE_FILES = 128;
    }

    public struct Address
    {
        [BitfieldLength(1)]
        public long Invalid { get; set; }
    }
}