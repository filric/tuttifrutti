using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            


            Console.WriteLine("Write your age:");

            int myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write your name:");

            string myName = Console.ReadLine();

            Console.WriteLine("Your age is " + myAge);

            Console.WriteLine("Your name is " + myName);

            Console.WriteLine("Are you alive? ");

            bool life = true;

            Console.WriteLine(life);


        }
    }
}
