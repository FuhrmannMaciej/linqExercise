using System;
using System.Collections.Generic;
using System.Linq;

namespace obietkowo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "ALA MA KOTA I KOT MA ALE";
            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
            string[] subStrings = text.Split(' ');
            foreach (var item in subStrings)
            {
                if (dictionary.ContainsKey(item.Length))
                {
                    dictionary[item.Length].Add(item);
                } else {
                dictionary.Add(item.Length, new List<string> { item });
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                foreach (var words in item.Value)
                {
                    Console.WriteLine(words);
                }
            }

            Console.WriteLine("-----------------");
            foreach (string word in subStrings)
            {
                Console.WriteLine(word.ToUpper());
            }
            Console.WriteLine("------------------");
            subStrings.Select(x => x.ToUpper()).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("-----------");
            int[] intTable = { 4, 5, 7, 8, 6, 3, 5, 7 };
            intTable.Select(x => x * 2).ToList().ForEach(Console.WriteLine);
            Console.WriteLine("--------------");
            intTable.Where(x => x > 6).Select( x => x*2).OrderBy(x => x).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("------------- to samo co na początku ale w LINQ -------------------");
            subStrings.GroupBy(x => x.Length).ToList().ForEach(x =>
            {
                Console.WriteLine(x.Key);
                x.ToList().ForEach(Console.WriteLine);
            });
        }
    }
}
