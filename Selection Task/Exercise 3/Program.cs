using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter first number to be summed.");
            string number1 = Console.ReadLine();
            int sum1 = int.Parse(number1);

            Console.WriteLine("Please Enter second number to be summed.");
            string number2 = Console.ReadLine();
            int sum2 = int.Parse(number2);

            // Selection if
            if (sum1 + sum2 >10) {
                Console.WriteLine("this number is higher then 10.");
            }
            else {
                Console.WriteLine("this number is not higher then 10.");
            }
        }
    }
}
