using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            
            int i = 1;
            Console.WriteLine("Lets Roll A Dice");
            Console.WriteLine("Enter Go to begin");
            

            //beggining of dice roll loop
            while (i > 0) {
            string input = Console.ReadLine();    
            Random rand = new Random();
            int num = rand.Next(1,7);
            list.Add(num);
                if (input == "stop") {
                Console.WriteLine("The list of your Rolls Are:");
                foreach(int anything in list)
                Console.WriteLine("["+anything+"]" );
                Console.WriteLine("The total of your rolls are:");
                int result = list.Sum();
                Console.WriteLine(result);
                Console.WriteLine("The Average of your Rolls Are:");
                double average = list.Average();
                Console.WriteLine(average);
                i--;
                }
                
                
                if (input == "go") {
                Console.WriteLine("Lets go again, Enter Go to roll again, Enter Stop to finish or Enter Rolls to see specific amount of rolls.");
                }
                if (input == "rolls") {
                    Console.WriteLine("Enter amount of rolls to see:");
                    string select = Console.ReadLine();
                    int selection = int.Parse(select);
                    Console.WriteLine("The last " + selection +" rolls are:");
                    foreach(int firstitems in list.Take(selection))
                    Console.WriteLine(firstitems);
                    var variables = list.Take(selection);
                    Console.WriteLine("The sum of your rolls are:");
                    int total1 = variables.Sum();
                    Console.WriteLine(total1);
                    Console.WriteLine("The Average of your Rolls Are:");
                    double average1 = variables.Average();
                    Console.WriteLine(average1);
                }
                
            }
                
            
            
           
            

            

        }
    }
}
