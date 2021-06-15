using System;

namespace exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is a prime number:");
            string a = Console.ReadLine();
            int num = int.Parse(a);
            int num1 =0;
            int i;
            for (i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(num+" is not a Prime Number");
                    num1 = 1;
                    i++;
                }
            }
            if (num1 == 0) {
                Console.Write(num+ " is a Prime Number");
            }
 
        }
    }
}
