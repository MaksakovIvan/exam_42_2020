using System.Collections.Generic;
using Xunit;

namespace ConsoleApp
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dictionary.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dictionary["a"].Add("b", new Dictionary<string, string>());
            dictionary["a"]["b"].Add("c", "World");
            dictionary["a"]["b"].Add("d", "Hello");
            Dictionary<string, string> truedict = new Dictionary<string, string>();
            truedict.Add("a/b/c", "World");
            truedict.Add("a/b/d", "Hello");
            Assert.Equal(truedict, Program.SetNewDictionary(dictionary));
        }

        [Fact]
        public void Test2()
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            Dictionary<string, string> truedict = new Dictionary<string, string>();
            Assert.Equal(truedict, Program.SetNewDictionary(dictionary));
        }
    }
}