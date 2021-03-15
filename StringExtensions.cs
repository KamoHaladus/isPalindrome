using Xunit;

namespace IsPalindrom
{
    using System;

    public static class StringExtensions
    {
        public static bool IsPalindrom(this string x)
        {
            //TODO
            throw new NotImplementedException();
        }
    }

    public class Tests
    {
        [Fact]
        public void Test_IsPalindrom()
        {
            Assert.True("kajak".IsPalindrom());
            Assert.False("abcdef".IsPalindrom());
            Assert.True("abba".IsPalindrom());
            Assert.True("".IsPalindrom());
            Assert.False("ababb".IsPalindrom());
            Assert.False("aA".IsPalindrom());
        }
    }
}
