using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Gender.");
            string gender = Console.ReadLine();
            string age = Console.ReadLine();
            int ageNum = int.Parse(age); 

            //selection if
            if (gender =="M")
            {
               
                Console.WriteLine("Please enter age");
                
                //Chain selection if
                if (ageNum >=18) {
                    Console.WriteLine("M is an adult");
                }
                
                //Chain selection else
                else {
                    Console.WriteLine("M is not an adult"); 
                }

            }
            //selection else
            else {
                Console.WriteLine("Please Enter age"); 
            }
                if (ageNum >=18) {
                    Console.WriteLine("F is an adult");
                }
                
                //Chain selection else
                else {
                    Console.WriteLine("F is not an adult"); 
                }
        }
    }
}
