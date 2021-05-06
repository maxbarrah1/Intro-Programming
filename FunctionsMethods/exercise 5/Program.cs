using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers into array");
            string[] numbers = new string [5];
            numbers [0] = Console.ReadLine();
            int a = int.Parse(numbers [0]);
            numbers [1] = Console.ReadLine();
            int b = int.Parse(numbers [1]);
            numbers [2] = Console.ReadLine();
            int c = int.Parse(numbers [2]);
            numbers [3] = Console.ReadLine();
            int d = int.Parse(numbers [3]);
            numbers [4] = Console.ReadLine();
            int e = int.Parse(numbers [4]);

            Console.WriteLine("the sum of all the numbers: ");
            Console.WriteLine(a+b+c+d+e);
        }
    }
}
