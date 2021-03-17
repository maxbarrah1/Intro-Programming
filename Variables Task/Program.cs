using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string word_1;
            string word_2;
            string word_3;
            string word_4;
            string word_5;
            int num_1;
            int num_2;
            int num_3;
            Console.WriteLine("Enter Firstname (please place a space after entry)");
            word_1 = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            word_2 = Console.ReadLine();
            Console.WriteLine("Enter Student ID");
            word_3 = Console.ReadLine();
            Console.WriteLine("Enter Year of Birth");
            word_4 = Console.ReadLine();
            Console.WriteLine("Enter Current Year");
            word_5 = Console.ReadLine();

            num_1 = int.Parse(word_3);
            num_2 = int.Parse(word_4);
            num_3 = int.Parse(word_5);


            Console.WriteLine(word_1 + word_2);
            Console.WriteLine(num_3 - num_2);
            Console.WriteLine(num_1);



        
        }
    }
}
