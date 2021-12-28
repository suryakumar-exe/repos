using System;
using System.Collections.Generic;
namespace BasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                Id = 101,
                Name = "surya",
                salary = 20000
            };
            Customer c2 = new Customer
            {
                Id = 102,
                Name = "Nila",
                salary = 500000
            };
            Customer c3 = new Customer
            {
                Id = 103,
                Name = "Keerthi",
                salary = 200000
            };
            Dictionary<int, Customer> dic = new Dictionary<int, Customer>();
           
            dic.Add(c1.Id, c1);
            dic.Add(c2.Id, c2);
            dic.Add(c3.Id, c3);
            if (dic.ContainsKey(c1.Id))
            {
                dic.Add(c3.Id, c3);
            }
            dic.Add(c1.Id, c3);
            Customer c = dic[102];
            foreach(Customer key in dic.Values)
            {
                
                
                Console.WriteLine(key.Name);
            }
           

        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int salary { get; set; }
        }
    }
}
