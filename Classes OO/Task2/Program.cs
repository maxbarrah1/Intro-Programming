using System;
using Task2.Classes;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creatte people
            person p1 = new person ("Max ", "Barrah", 180, new DateTime(1999, 9, 15));
            person p2 = new person ("John ", "Smith", 170, new DateTime(1997, 7, 11));
            person p3 = new person ("Sean ", "Johnson", 160, new DateTime(2000, 4, 27));
            //task 1
            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(p2.GetFullName());
            System.Console.WriteLine(p3.GetFullName());
            //task 2
            System.Console.WriteLine(p3.GetHeightDifference(p2));
            System.Console.WriteLine(p2.GetHeightDifference(p1));
            System.Console.WriteLine(p3.GetHeightDifference(p1));
            
            //task 3
            p1.Addsubject(new subject("English", 2015));
            p3.Addsubject(new subject("English", 2011));
            p2.Addsubject(new subject("Woodwork", 2014));
            p3.Addsubject(new subject("Math", 2018));
            p2.Addsubject(new subject("Religion", 2019));

            //task 4
            p2.Setgrade("English", "A");
            p2.Getsubject();
        }
    }
}
