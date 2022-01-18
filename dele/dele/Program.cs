using System;
using System.Collections.Generic;
using System.Linq;

namespace dele
{
    class Program
    {
        private static List<KeyValuePair<string, int>> d = new List<KeyValuePair<string, int>>();
        static void Main(string[] args)
        {

            d.Add(new KeyValuePair<string, int>("joe", 100));
            d.Add(new KeyValuePair<string, int>("joe", 200));
            d.Add(new KeyValuePair<string, int>("jim", 100));
            var result = d.Where(x => x.Key == "joe");
            foreach (var q in result)
                Console.WriteLine(q.Value);
            Console.ReadLine();

        }
    }
}
