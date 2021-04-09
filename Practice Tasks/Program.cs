using System;

namespace Practice_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Name:");
            string name = Console.ReadLine(); 
            int counter = 0;
            counter++;
            
            while (counter < 10) {
                int counter2 = 0;
                
                while (counter2 < 10) {
                    Console.WriteLine(name);
                    counter2 = counter2 + 1; 
                
                 

                 Console.WriteLine(counter);
                    counter = counter + 1;
                }

        
            
            Console.WriteLine("Goodbye");
            }
        }
    }
}
