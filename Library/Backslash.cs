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
        /// <param name="str">String to check</param>
        /// <returns>True if the given string starts with a backslash, false otherwise</returns>
        public static bool StartsWith(string str) { return _slash.StartsWith(str); }

        /// <summary>
        /// Returns true if the given string ends with a backslash, false otherwise.
        /// </summary>
        /// <param name="str">String to check</param>
        /// <returns>True if the given string ends with a backslash, false otherwise</returns>
        public static bool EndsWith(string str) { return _slash.EndsWith(str); }

        /// <summary>
        /// Trims backslashes from the given string.
        /// </summary>
        /// <param name="str">String to trim</param>
        /// <returns>The given string with backslashes trimmed</returns>
        public static string Trim(string str) { return _slash.Trim(str); }

        /// <summary>
        /// Trims leading backslashes from the given string.
        /// </summary>
        /// <param name="str">String to trim</param>
        /// <returns>The given string with leading backslashes trimmed</returns>
        public static string TrimStart(string str) { return _slash.TrimStart(str); }

        /// <summary>
        /// Trims trailing backslashes from the given string.
        /// </summary>
        /// <param name="str">String to trim</param>
        /// <returns>The given string with trailing backslashes trimmed</returns>
        public static string TrimEnd(string str) { return _slash.TrimEnd(str); }

        /// <summary>
        /// Joins with backslashes the given strings.
        /// </summary>
        /// <param name="str">Strings to join</param>
        /// <returns>The given strings joined with backslashes</returns>
        public static string Join(params string[] str) { return _slash.Join(str); }

        /// <summary>
        /// Joins with backslashes the given strings while trimming the backslashes in each string.
        /// </summary>
        /// <param name="str">Strings to trim then join</param>
        /// <returns>The given strings trimmed and joined with backslashes</returns>
        public static string JoinTrimming(params string[] str) { return _slash.JoinTrimming(str); }

        /// <summary>
        /// Splits the given string where backslashes appears.
        /// </summary>
        /// <param name="str">String to split</param>
        /// <returns>The given string splitted where backslashes appears</returns>
        public static string[] Split(string str) { return _slash.Split(str, true); }

        /// <summary>
        /// Splits the given string where backslashes appears.
        /// Leaves empty entries on the resulting collection.
        /// </summary>
        /// <param name="str">String to split</param>
        /// <returns>The given string splitted where backslashes appears</returns>
        public static string[] SplitLeavingEmpty(string str) { return _slash.Split(str, false); }
    }
}
