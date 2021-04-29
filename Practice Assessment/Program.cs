using System;
using System.Collections.Generic;

namespace Practice_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            int num = rand.Next(0,25);
            int guesses = 7;
            Console.WriteLine("Hey there! Lets play a guessing game.");
            Console.WriteLine("Guess a number between 0 and 25");
            while (guesses > 0) 
            {
                int guess = int.Parse(Console.ReadLine());
                list.Add(guess);

                if (guess > num) {
                    Console.WriteLine("Nope its less than that");
                    Console.WriteLine("Number of guesses remaining: " + guesses);
                    Console.WriteLine("Try Again!");
                }

                if (guess < num) {
                    Console.WriteLine("Nope its greater than that");
                    Console.WriteLine("Number of guesses remaining: " + guesses);
                    Console.WriteLine("Try Again!");
                }
                
                if (guess == num) {
                    Console.WriteLine("Congrats! you win");
                    Console.WriteLine("Your guess log:"); 
                    foreach(int anything in list) 
                    Console.Write("["+anything+"]" );
                }
                

               
               guesses--;

                
            }
            
                Console.WriteLine("You Lose");
                Console.WriteLine("The number was " + num);
                Console.WriteLine("Your guess log:");
                foreach(int anything in list) 
                Console.Write("["+anything+"]" );
            
        }
    }
}
