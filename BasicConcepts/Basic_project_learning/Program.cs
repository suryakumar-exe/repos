using System;

namespace Basic_project_learning
{
    class Program
    {
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday);
            var wd = (int)WeekDays.Saturday;
            Console.WriteLine(wd);
            var wd1 = (WeekDays)5;
            Console.WriteLine(wd1);
        }
    }
}
