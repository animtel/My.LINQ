using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "AAA", "BBB", "CCC", "BABA", "ABAB", "BCBC" };
            List<string> list = new List<string>();

            var some = from w in words
                       where w.ToUpper().StartsWith("B")
                       orderby w
                       select w;

            foreach (var item in some)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\r\n Method of extansion \r\n");
            var selectedTeams = some.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);
            foreach (var item in some)
            {
                Console.WriteLine(item);
            }
        }
    }
}
