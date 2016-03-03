namespace SlashLibrary
{
    /// <summary>
    /// Utility methods for dealing with backslashes in strings.
    /// </summary>
    public static class Backslash
    {
        private static readonly _Slash _slash = new _Slash('\\');

        /// <summary>
        /// Returns true if the given string starts with a backslash, false otherwise.
        /// </summary>
        /// <param name="string">String to check</param>
        /// <returns>True if the given string starts with a backslash, false otherwise</returns>
        public static bool StartsWith(string @string) { return _slash.StartsWith(@string); }

        /// <summary>
        /// Returns true if the given string ends with a backslash, false otherwise.
        /// </summary>
        /// <param name="string">String to check</param>
        /// <returns>True if the given string ends with a backslash, false otherwise</returns>
        public static bool EndsWith(string @string) { return _slash.EndsWith(@string); }

        /// <summary>
        /// Trims backslashes from the given string.
        /// </summary>
        /// <param name="string">String to trim</param>
        /// <returns>The given string with backslashes trimmed</returns>
        public static string Trim(string @string) { return _slash.Trim(@string); }

        /// <summary>
        /// Trims leading backslashes from the given string.
        /// </summary>
        /// <param name="string">String to trim</param>
        /// <returns>The given string with leading backslashes trimmed</returns>
        public static string TrimStart(string @string) { return _slash.TrimStart(@string); }

        /// <summary>
        /// Trims trailing backslashes from the given string.
        /// </summary>
        /// <param name="string">String to trim</param>
        /// <returns>The given string with trailing backslashes trimmed</returns>
        public static string TrimEnd(string @string) { return _slash.TrimEnd(@string); }

        /// <summary>
        /// Joins with backslashes the given strings.
        /// </summary>
        /// <param name="strings">strings to join</param>
        /// <returns>The given strings joined with backslashes</returns>
        public static string Join(params string[] strings) { return _slash.Join(strings); }

        /// <summary>
        /// Joins with backslashes the given strings while trimming the backslashes in each string.
        /// </summary>
        /// <param name="strings">strings to trim then join</param>
        /// <returns>The given strings trimmed and joined with backslashes</returns>
        public static string JoinTrimming(params string[] strings) { return _slash.JoinTrimming(strings); }

        /// <summary>
        /// Splits the given string where backslashes appears.
        /// </summary>
        /// <param name="string">string to split</param>
        /// <param name="removeEmpty">flag indicating to remove empty entries after the split</param>
        /// <returns>The given string splitted where backslashes appears</returns>
        public static string[] Split(string @string, bool removeEmpty = true) { return _slash.Split(@string, removeEmpty); }
    }
}
