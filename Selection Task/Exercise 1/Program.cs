using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Age.");
            string age = Console.ReadLine();
            int ageNum = int.Parse(age);

            // Selection if
            if (ageNum >= 16) {
                Console.WriteLine("Legally Adult Age.");
            }
            else {
                Console.WriteLine("Legally Not adult Age.");
            }
        }
    }
}
