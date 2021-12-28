using System;

namespace Training_Tutorial
{

   class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Pig : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Animal Sound:Wee Wee");
        }
    }
    class Dog :Animal
    {
        public override void sound()
        {
            Console.WriteLine("Animal Sound:Bow Bow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            ani.sound();
            pig.sound();
            dog.sound();


        }
    }
}
