using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number to be summed");
            string a = Console.ReadLine();
            int c = int.Parse(a);
            Console.WriteLine("Enter second number to be summed");
            string b = Console.ReadLine();
            int d = int.Parse(b);

            int result = (c + d);
            Console.WriteLine("Your answer is:");
            Console.WriteLine(result);
            
        }
    }
}
