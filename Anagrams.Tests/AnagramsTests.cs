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
            Assert.Equal("Следует заменить 1 букв(-ы)", Program.Anagrams("cat", "cot"));
        }

        [Fact]
        public void WordsCarAndCoz()
        {
            Assert.Equal("Следует заменить 2 букв(-ы)", Program.Anagrams("cat", "coz"));
        }

        [Fact]
        public void WordsCarsAndCat()
        {
            Assert.Equal("Слова не равной длинны", Program.Anagrams("cars", "cat"));
        }

        [Fact]
        public void WordsDeerAndDeep()
        {
            Assert.Equal("Следует заменить 1 букв(-ы)", Program.Anagrams("deer", "deep"));
        }

        [Fact]
        public void WordsMrahAndHarm()
        {
            Assert.Equal("Данные слова уже являются анаграммами", Program.Anagrams("mrah", "harm"));
        }

        [Fact]
        public void WordsDarkAndYyyy()
        {
            Assert.Equal("Следует заменить 4 букв(-ы)", Program.Anagrams("dark", "yyyy"));
        }

        [Fact]
        public void WordsAgarAndGras()
        {
            Assert.Equal("Следует заменить 1 букв(-ы)", Program.Anagrams("agar", "gras"));
        }
    }
}
