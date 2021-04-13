using System;

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

            Console.Write("a random number ");
            var firstNumberAsString = Console.ReadLine();
            Console.Write("another random number ");
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine("The sum of your numbers are" + sum);
            Console.WriteLine("The difference of your numbers are" + difference);
            Console.WriteLine("The product of your numbers are" + product);
            Console.WriteLine("The quotient of your numbers are" + quotient);
            Console.WriteLine("The remainder of your numbers are" + remainder);





        }
    }
}
