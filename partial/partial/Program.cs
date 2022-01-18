using System;
using System.Text.RegularExpressions;

namespace partial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string s = "Sri@123";
            string[] sub = s.Split('@');
            Console.WriteLine(sub[0]+" "+sub[1]);
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";

            foreach (var item in s)
            {
                if (specialChar.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
