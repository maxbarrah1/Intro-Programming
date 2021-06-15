using System;
namespace Task2.Classes

{
    public class subject
    {
        

        public string name { get; set; }
        public int year { get; set; }
        public string grade { get; set; }

        public subject(string name, int year)
        {
            this.name = name;
            this.year = year; 
        }
        public void WriteSubject() {
        Console.WriteLine( $"Name: {name}, Year: {year}, Grade: {grade}");

        }
    }
}