using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> finalDic = new Dictionary<string, string>();

            Dictionary<string, string> firstDic = new Dictionary<string, string>
                {
                    {"1", "red"},
                    {"2","orange"}
                };

                            Dictionary<string, string> secondDic = new Dictionary<string, string>
                {
                    {"3", "green"},
                    {"4", "yellow"}
                };

            firstDic.Concat(secondDic);
            foreach (var kk in firstDic)
            {
                finalDic.Add(kk.Key, kk.Value);
            }
            foreach (var kk1 in secondDic)
            {
                finalDic.Add(kk1.Key, kk1.Value);
            }

            foreach (var kvp in finalDic)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();

            /* Dictionary<string, string> d1 = new Dictionary<string, string>();
             d1.Add("name1", "surya");
             d1.Add("name2", "raina");
             Dictionary<string, string> d2 = new Dictionary<string, string>();
             d2.Add("name3", "surya1");
             d2.Add("name4", "raina1");
             d1.Union(d2).ToDictionary(p=>p.Key,p=>p.Value);
             foreach(var i in d1.Keys)
             {
                 Console.WriteLine(i);
             }

             Console.WriteLine(d2);*/
        }
    }
}
