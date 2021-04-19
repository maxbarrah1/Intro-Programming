using System;

namespace Practice_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
           {
            int counter = 0;
            Console.Write("enter amount of x's:");
            int limi = int.Parse(Console.ReadLine());
            
            
            while (counter < limi) {
                
                int counter2 = 0;
                
                while (counter2 <= counter)
                {
                    Console.Write("x");

                    counter2++;

                }
                counter++;
                Console.WriteLine();
            }
                
            


           }
        }
    }
}
