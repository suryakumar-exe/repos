using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicConcepts
{
    class Dictionary_using_Array
    {
        static void Main(string[] args)
        {


            Thread mainthread = Thread.CurrentThread;
            mainthread.Name = "Main Thread";
            Thread t1 = new Thread(new ThreadStart(CountDown));
            Thread t2 = new Thread(new ThreadStart(CountUp));
            t1.Start();
            t2.Start();
          
            Console.WriteLine(mainthread.Name + " is completed");
            //Assign the value in Array of Object Format
            Employee[] employees =
            {
            new Employee("CEO","Surya",20,null),
            new Employee("Manager","Nila",17,null)
        };



            //Add the values in key-Value pair
            Dictionary<string, Employee> empdic = new Dictionary<string, Employee>();


            foreach(Employee emp in employees)
            {
                empdic.Add(emp.Role, emp);
            }

            /*string key = "CEO1";
            if (empdic.ContainsKey(key))
            {
                Employee empl = empdic[key];
                Console.WriteLine(empl.Name);
            }
            else
            {
                Console.WriteLine("not contain "+key);
            }*/

            /*Employee result = null;
            if(empdic.TryGetValue("CEO",out result))
            {
                Console.WriteLine(result.Name);
            }
            else
            {
                Console.WriteLine("not contain");
            }*/

            //update based on key
            /* Employee result = null;
             string updating_key = "CEO";
             string updating_name = "Raina";
             if (empdic.TryGetValue(updating_key, out result))
             {
                 empdic[updating_key] = new Employee("CEO", updating_name, 20);
                 Console.WriteLine("updated");
                 // Console.WriteLine(result.Name);
             }
             else
             {
                 Console.WriteLine("not contain");
             }
 */

            //Delete
            /*Employee result1 = null;
            string delete_key = "Surya";
            if (empdic.Remove(delete_key))
            {
                Console.WriteLine("updated");
                // Console.WriteLine(result.Name);
            }
            else
            {
                Console.WriteLine("not contain key");
            }*/

            foreach (var d in empdic)
            {
                
                Employee value = d.Value;

                string updating_key = d.Key;
                if (value.Age >= 18)
                {
                  
                    string updating_vote = "eligible to vote";
                    empdic[updating_key] = new Employee("CEO", value.Name, value.Age, updating_vote);
                    
                }
                else
                {
                 
                    string updating_vote = "Not eligible to vote";
                    empdic[updating_key] = new Employee("CEO", value.Name, value.Age, updating_vote);
                    
                }
            }
           /* foreach (var d in empdic)
            {
                //Console.WriteLine(d.Key);
                Employee value = d.Value;
                Console.WriteLine("{0} {1} {2} {3}", value.Role, value.Name, value.Age,value.Vote);
            }
*/

            /*Console.WriteLine("Queue Tasks");
            QueueTask q = new QueueTask();
            q.QTask();*/

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

    
    class Employee
    {
        public Employee(string role, string name, int age, string vote)
        {
            Role = role;
            Name = name;
            Age = age;
            Vote = vote;
        }

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Vote { get; set; }

    }
}
