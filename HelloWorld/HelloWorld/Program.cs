using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Choose a language you want to be greeted in.");
            Console.WriteLine("Type 1 for english, 2 for japanese and 3 for klingon:");

            var languageChoice = Convert.ToInt32(Console.ReadLine());

            switch (languageChoice)
            {
                case 1:
                    Console.WriteLine("Hello Niklas!");
                    break;
                case 2:
                    Console.WriteLine("やあニクラス！");
                    break;
                case 3:
                    Console.WriteLine("tlhIHqu' 'ej *tlhaw'DIyo* quv!");
                    break;
            }



                    Console.WriteLine("Write your age:");

            int myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write your name:");

            string myName = Console.ReadLine();

            Console.WriteLine("Your age is " + myAge);
            if (myAge > 17)
            {
                Console.WriteLine("Congratulations! You can now get a driverslicense!");
            }
            else
            {
                Console.WriteLine("You are a baby");
            }
            Console.WriteLine("Lets count from 0 to your age");
            int i = 0;
            while (i<= myAge)
                {
                Console.WriteLine(i);
                i++;
                }
            Console.WriteLine("Lets count from your age to 0");
            for (int j = myAge; j > -1; j--)
            {
                Console.WriteLine(j);
            }



            Console.WriteLine("Your name is " + myName);

            Console.WriteLine("Are you alive? ");

            bool life = true;

            Console.WriteLine(life);



        }
    }
}
