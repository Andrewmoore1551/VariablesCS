﻿using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 0;

            var fullName = "Andrew Moore";

            var today = DateTime.Now;

            Console.WriteLine($"The number of cups of coffee i drink is {numberOfCupsOfCoffee}, my name is {fullName}, the date time is {today} ");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();

            Console.WriteLine($"It is nice to meet you {userName}");





        }
    }
}
