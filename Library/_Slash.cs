namespace Slashes
{
    using System;
    using System.Linq;

    internal class _Slash
    {
        private readonly char _slash;

        internal _Slash(char slash)
        {
            _slash = slash;
        }

        internal bool StartsWith(string @string)
        {
            return @string.StartsWith(_slash.ToString());
        }

        internal bool EndsWith(string @string)
        {
            return @string.EndsWith(_slash.ToString());
        }

        internal string Trim(string @string)
        {
            return @string.Trim(_slash);
        }

        internal string TrimStart(string @string)
        {
            return @string.TrimStart(_slash);
        }

        internal string TrimEnd(string @string)
        {
            return @string.TrimEnd(_slash);
        }

        internal string Join(params string[] strings)
        {
            var filtered = strings.Where(s => !string.IsNullOrWhiteSpace(s));
            return string.Join(_slash.ToString(), filtered);
        }

        internal string JoinTrimming(params string[] strings)
        {
            var trimmed = strings.Select(s => s is string ? Trim((string)s) : s);
            return Trim(string.Join(_slash.ToString(), trimmed));
        }

        internal string[] Split(string @string, bool removeEmpty)
        {
            var options = removeEmpty ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None;
            return @string.Split(new[] { _slash }, options);
        }
    }
}
