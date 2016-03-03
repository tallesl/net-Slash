namespace SlashLibrary.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void StartsWith()
        {
            Assert.IsTrue(Slash.StartsWith(@"/Yes, it does."));
            Assert.IsTrue(Backslash.StartsWith(@"\Yes, it does."));

            Assert.IsFalse(Slash.StartsWith("Nope."));
            Assert.IsFalse(Backslash.StartsWith("Nope."));
        }

        [TestMethod]
        public void EndsWith()
        {
            Assert.IsTrue(Slash.EndsWith(@"Yes, it does./"));
            Assert.IsTrue(Backslash.EndsWith(@"Yes, it does.\"));

            Assert.IsFalse(Slash.EndsWith("Nope."));
            Assert.IsFalse(Backslash.EndsWith("Nope."));
        }

        [TestMethod]
        public void Trim()
        {
            Assert.AreEqual("Where're my slashes?", Slash.Trim(@"/Where're my slashes?/"));
            Assert.AreEqual("Where're my backslashes?", Backslash.Trim(@"\Where're my backslashes?\"));

            Assert.AreEqual("Nothing to trim.", Slash.Trim("Nothing to trim."));
            Assert.AreEqual("Nothing to trim.", Backslash.Trim("Nothing to trim."));
        }

        [TestMethod]
        public void TrimStart()
        {
            Assert.AreEqual("Where're my slashes?", Slash.TrimStart(@"/Where're my slashes?"));
            Assert.AreEqual("Where're my backslashes?", Backslash.TrimStart(@"\Where're my backslashes?"));

            Assert.AreEqual("Nothing to trim.", Slash.TrimStart("Nothing to trim."));
            Assert.AreEqual("Nothing to trim.", Backslash.TrimStart("Nothing to trim."));
        }

        [TestMethod]
        public void TrimEnd()
        {
            Assert.AreEqual("Where're my slashes?", Slash.TrimEnd(@"Where're my slashes?/"));
            Assert.AreEqual("Where're my backslashes?", Backslash.TrimEnd(@"Where're my backslashes?\"));

            Assert.AreEqual("Nothing to trim.", Slash.TrimEnd("Nothing to trim."));
            Assert.AreEqual("Nothing to trim.", Backslash.TrimEnd("Nothing to trim."));
        }

        [TestMethod]
        public void Join()
        {
            Assert.AreEqual(@"One/Two/Three", Slash.Join(new[] { "One", "Two", "Three" }));
            Assert.AreEqual(@"One\Two\Three", Backslash.Join(new[] { "One", "Two", "Three" }));

            Assert.AreEqual("Nothing to join.", Slash.Join(new[] { "Nothing to join." }));
            Assert.AreEqual("Nothing to join.", Backslash.Join(new[] { "Nothing to join." }));
        }

        [TestMethod]
        public void JoinTrimming()
        {
            Assert.AreEqual(@"One/Two/Three", Slash.JoinTrimming("/One", "Two/", "/Three/"));
            Assert.AreEqual(@"One\Two\Three", Backslash.JoinTrimming(@"\One", @"Two\", @"\Three\"));

            Assert.AreEqual("Nothing to join.", Slash.JoinTrimming("Nothing to join."));
            Assert.AreEqual("Nothing to join.", Backslash.JoinTrimming("Nothing to join."));
        }

        [TestMethod]
        public void Split()
        {
            Assert.IsTrue(new[] { "One", "Two", "Three" }.SequenceEqual(Slash.Split(@"One/Two/Three")));
            Assert.IsTrue(new[] { "One", "Two", "Three" }.SequenceEqual(Backslash.Split(@"One\Two\Three")));

            Assert.IsTrue(new[] { "One", "", "Two", "", "Three" }.SequenceEqual(Slash.Split(@"One//Two//Three", false)));
            Assert.IsTrue(new[] { "One", "", "Two", "", "Three" }.SequenceEqual(Backslash.Split(@"One\\Two\\Three", false)));

            Assert.IsTrue(new[] { "Nothing to split." }.SequenceEqual(Slash.Split("Nothing to split.")));
            Assert.IsTrue(new[] { "Nothing to split." }.SequenceEqual(Backslash.Split("Nothing to split.")));
        }
    }
}
