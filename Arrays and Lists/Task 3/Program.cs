using System;
using System.Collections.Generic;

namespace Task_3
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



            if (number == nums) {
                Console.WriteLine("This number has been entered"); }

                else if (number == nums1) {
                Console.WriteLine("This number has been entered"); }

               else  if (number == nums2) {
                Console.WriteLine("This number has been entered"); }

               else if (number == nums3) {
                Console.WriteLine("This number has been entered"); }

                else if (number == nums4) {
                Console.WriteLine("This number has been entered"); }

            else
            {
                Console.WriteLine("This number has not been entered"); }

                
                
            


        }
    }
}
