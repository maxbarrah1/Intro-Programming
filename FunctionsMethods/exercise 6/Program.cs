using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string a = Console.ReadLine();
            int c = int.Parse(a);
            Console.WriteLine("Enter second number ");
            string b = Console.ReadLine();
            int d = int.Parse(b);

    
            Console.WriteLine("the first number is " + d + " the second number is " + c);
            
        }
    }
}
