﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal smulan = new Animal();
            smulan._name = "Smulan";
            smulan._species = "Dog";
            smulan._color = "Green";

            Person niklas = new Person("Niklas", 33, smulan);

            niklas.Eat();
            niklas.Sleep();

            niklas.ActivatePet();
        }
    }
}
