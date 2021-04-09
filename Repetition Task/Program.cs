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
                
            
                if (counter % 3 == 0) 
                {
                    Console.WriteLine("Fizz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else 
                {
                    Console.WriteLine(counter);
                }
                counter ++;
            }



        }
    }
}
