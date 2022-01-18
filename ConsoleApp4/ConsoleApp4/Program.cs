using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
      
        static void Main(string[] args)
        {
            List<KeyValuePair<string, int>> d = new List<KeyValuePair<string, int>>();
            d.Add(new KeyValuePair<string, int>("joe", 100));
            d.Add(new KeyValuePair<string, int>("joe", 200));
            d.Add(new KeyValuePair<string, int>("jim", 100));
            d.Add(new KeyValuePair<string, int>("jim", 100));

            int f = 0;
            foreach (var q in d)
            {
                if((q.Key == "Jimmy" ) && (q.Value == 101))
                {
                    f += 1;
                }
            }
            if (f == 0)
            {
                d.Add(new KeyValuePair<string, int>("jimmy", 101));
            }
                
            Console.ReadLine();
        }
    }
}
