namespace Slashes
{
    /// <summary>
    /// Utility methods for dealing with slashes in strings.
    /// </summary>
    public static class Slash
    {
        private static readonly _Slash _slash = new _Slash('/');

        /// <summary>
        /// Returns true if the given string starts with a slash, false otherwise.
        /// </summary>
        /// <param name="string">String to check</param>
        /// <returns>True if the given string starts with a slash, false otherwise</returns>
        public static bool StartsWith(string @string) { return _slash.StartsWith(@string); }

        /// <summary>
        /// Returns true if the given string ends with a slash, false otherwise.
        /// </summary>
        /// <param name="string">String to check</param>
        /// <returns>True if the given string ends with a slash, false otherwise</returns>
        public static bool EndsWith(string @string) { return _slash.EndsWith(@string); }

        /// <summary>
        /// Trims slashes from the given string.
        /// </summary>
        /// <param name="string">String to trim</param>
        /// <returns>The given string with slashes trimmed</returns>
        public static string Trim(string @string) { return _slash.Trim(@string); }

        /// <summary>
        /// Trims leading slashes from the given string.
        /// </summary>
        /// <param name="string">String to trim</param>
        /// <returns>The given string with leading slashes trimmed</returns>
        public static string TrimStart(string @string) { return _slash.TrimStart(@string); }

        /// <summary>
        /// Trims trailing slashes from the given string.
        /// </summary>
        /// <param name="string">String to trim</param>
        /// <returns>The given string with trailing slashes trimmed</returns>
        public static string TrimEnd(string @string) { return _slash.TrimEnd(@string); }

        /// <summary>
        /// Joins with slashes the given strings.
        /// </summary>
        /// <param name="strings">strings to join</param>
        /// <returns>The given strings joined with slashes</returns>
        public static string Join(params string[] strings) { return _slash.Join(strings); }

        /// <summary>
        /// Joins with slashes the given strings while trimming the slashes in each string.
        /// </summary>
        /// <param name="strings">strings to trim then join</param>
        /// <returns>The given strings trimmed and joined with slashes</returns>
        public static string JoinTrimming(params string[] strings) { return _slash.JoinTrimming(strings); }

        /// <summary>
        /// Splits the given string where slashes appears.
        /// </summary>
        /// <param name="string">string to split</param>
        /// <param name="removeEmpty">flag indicating to remove empty entries after the split</param>
        /// <returns>The given string splitted where slashes appears</returns>
        public static string[] Split(string @string, bool removeEmpty = true) { return _slash.Split(@string, removeEmpty); }
    }
}
