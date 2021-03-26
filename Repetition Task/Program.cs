using System;

namespace Repetition_Task
{
    class Program
    {
        static void Main(string[] args)
        {
             //where counter begins
             for (int counter = 1; counter <=100;){
             //create repetition
             counter++;
             //create Fizz Buzz variables
                 Console.WriteLine(counter);
                if (counter % 3 == 0){
                    Console.WriteLine("Fizz");}
                if (counter % 5 == 0){
                    Console.WriteLine("Buzz");}
                if (counter % 3 == 0 && counter % 5 == 0){
                    Console.WriteLine("FizzBuzz");}
             }
                  
            

        }
    }
}
