using System;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String[] names = new string[5];

            Console.WriteLine("Skriv 5 namn");

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
                
            }
            Console.WriteLine("And here they are backwards: ");


            for(int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

           
        }
    }
}
