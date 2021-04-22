using System;
using System.Collections.Generic;
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            int nums = int.Parse(list [0]);
            int nums1 = int.Parse(list [1]);
            int nums2 = int.Parse(list [2]);
            int nums3 = int.Parse(list [3]);
            int nums4 = int.Parse(list [4]);

            Console.WriteLine("please enter a number");
            string given = Console.ReadLine();
            int number = int.Parse(given);
            int counter = 0;
            
            for (int index = 0; index < 5; index++) {
                

                if (given == list[index]) {
                    counter++;
                }
                


            }  //for (int index = 0; index < 5; index++) {
            Console.WriteLine("This number has been this many times: " + counter); 
            
                
                
           
        }
    }
}
