using System;

namespace test1
{
    class Addition
    {
        static void Main2(string[] args)
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter First Integer  "); // prompt user
            number1 = int.Parse(Console.ReadLine()); // Read first integer from the user

            Console.Write("Enter Second Integer  ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2; // Add numbers

            Console.WriteLine($"The sum of {number1} and {number2} is {sum}");

            if (number1 != number2) 
            {
                Console.WriteLine($"Therefore {number1} != {number2}");
            }

        }
    }
}
