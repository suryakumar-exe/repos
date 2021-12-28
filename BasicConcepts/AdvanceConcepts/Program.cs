using System;
using System.Threading;

namespace AdvanceConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainthread = Thread.CurrentThread;
            mainthread.Name = "Main Thread";
            Thread t1 = new Thread(new ThreadStart(CountDown));
            Thread t2 = new Thread(new ThreadStart(CountUp));
            t1.Start();
            t2.Start();

            Console.WriteLine(mainthread.Name + " Main is completed");
        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 " + i + " Sec");
                Thread.Sleep(1000);
            }
            Console.WriteLine("1 Completed");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 " + i + " Sec");
                Thread.Sleep(1000);
            }
            Console.WriteLine("2 Completed");
        }
    }
}
