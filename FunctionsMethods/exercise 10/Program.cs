using System;

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("enter a number to add the digits: ");
            string a = Console.ReadLine();
            int num = int.Parse(a);
            int sum = 0;
            while (num != 0) 
            {
            sum += num % 10;
            num /= 10;
            }
            Console.WriteLine("the sum of the numbers is: " + sum);
            
            
        }
    }
}
