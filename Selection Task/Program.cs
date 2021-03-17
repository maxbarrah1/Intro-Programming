using System;

namespace Intro_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Username.");
            string username = Console.ReadLine();
            

            //selection if
            if (username =="maxbarrah")
            {
                Console.WriteLine("Checking username...");
                Console.WriteLine("Success! Please Enter Password.");
                string password = (Console.ReadLine());

                //Chain selection if
                if (password =="password1") {
                    Console.WriteLine("Checking Password...");
                    Console.WriteLine("Login Succesful!"); 
                }
                
                //Chain selection else
                else {
                    Console.WriteLine("login Unsuccessful, Please Try Again."); 
                }

            }
            //selection else
            else {
            
                Console.WriteLine("Incorrect Username, Please Try Again."); 
            } 
        }

    }
}
