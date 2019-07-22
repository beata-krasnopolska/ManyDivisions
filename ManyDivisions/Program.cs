using System;

namespace ManyDivisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program asks the user for two numbers and shows their division and the remainder of the division. It warns if 0 is entered as first and as well as the the second number.");
            int number1;
            int number2;

            do
            {
                Console.WriteLine("Enter first number: ");
                number1 = int.Parse(Console.ReadLine());

                if (number1 != 0)
                {
                    Console.WriteLine("Enter second number: ");
                    number2 = int.Parse(Console.ReadLine());

                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0!!!");
                    }
                    else
                    {
                        Console.WriteLine("The result of division: {0}", number1 / number2);
                        Console.WriteLine("The reminder: {0}", number1 % number2);
                    }
                }
            } while (number1 != 0);
            if (number1 == 0)
            {
                Console.WriteLine("The result of division is the same!");
            }
            else
            {
                Console.WriteLine("Bye!!!");
            }
            
            Console.ReadKey();
        }
    }
}
