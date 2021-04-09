using System;

namespace Repetition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //where counter begins
            int counter = 0;
            while (counter <= 100)
            {

                //create Fizz Buzz variables
                Console.WriteLine(counter);

                if (counter % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else 
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }



        }
    }
}
