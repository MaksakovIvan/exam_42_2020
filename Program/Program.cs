using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Program
    {
        public static Dictionary<string, string> SetNewDictionary(Dictionary<string, Dictionary<string, Dictionary<string, string>>> dict)
        {
            Dictionary<string, string> dictresult = new Dictionary<string, string>();
            string reskey = "";
            foreach (var x in dict)
            {
                if (x.Value is Dictionary<string, Dictionary<string, string>>)
                {
                    reskey = x.Key + "/";
                    foreach (var y in x.Value)
                    {
                        if (y.Value is Dictionary<string, string>)
                        {
                            reskey += y.Key + "/";
                            foreach (var z in y.Value)
                            {
                                if (z.Value is string)
                                {
                                    dictresult.Add(reskey + z.Key, z.Value);
                                }
                            }
                        }
                    }
                }
            }
            return dictresult;
        }
        static public void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> dictionary = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            dictionary.Add("a", new Dictionary<string, Dictionary<string, string>>());
            dictionary["a"].Add("b", new Dictionary<string, string>());
            dictionary["a"]["b"].Add("c", "12");
            dictionary["a"]["b"].Add("d", "Hello World");
            foreach (var a in SetNewDictionary(dictionary))
            {
                Console.WriteLine(a);
            }


        }
    }
};