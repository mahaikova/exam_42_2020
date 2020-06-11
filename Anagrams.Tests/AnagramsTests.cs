using System;
using Xunit;
using Anagrams;

namespace Anagrams.Tests
{
    public class AnagramsTests
    {
        [Fact]
        public void WordsCarAndCot()
        {
            Assert.Equal("������� �������� 1 ����(-�)", Program.Anagrams("cat", "cot"));
        }

        [Fact]
        public void WordsCarAndCoz()
        {
            Assert.Equal("������� �������� 2 ����(-�)", Program.Anagrams("cat", "coz"));
        }

        [Fact]
        public void WordsCarsAndCat()
        {
            Assert.Equal("����� �� ������ ������", Program.Anagrams("cars", "cat"));
        }

        [Fact]
        public void WordsDeerAndDeep()
        {
            Assert.Equal("������� �������� 1 ����(-�)", Program.Anagrams("deer", "deep"));
        }

        [Fact]
        public void WordsMrahAndHarm()
        {
            Assert.Equal("������ ����� ��� �������� �����������", Program.Anagrams("mrah", "harm"));
        }

        [Fact]
        public void WordsDarkAndYyyy()
        {
            Assert.Equal("������� �������� 4 ����(-�)", Program.Anagrams("dark", "yyyy"));
        }

        [Fact]
        public void WordsAgarAndGras()
        {
            Assert.Equal("������� �������� 1 ����(-�)", Program.Anagrams("agar", "gras"));
        }
    }
}
