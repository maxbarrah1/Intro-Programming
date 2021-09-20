using System.Collections.Generic;
using System;
using week_2_exception_handling.Models;
namespace week_2_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string roomno;
            string name;
            DateTime date;
            DateTime time;
            int minutes;
            


            int dealerId;

            System.Console.Write("Please enter RoomID: ");
            roomno = Console.ReadLine();
            System.Console.Write("Please enter your Name: ");
            name = Console.ReadLine();
            
            System.Console.Write("Please enter Date of entry: ");
        
            try {
               var tempdate = Console.ReadLine(); 
               date = DateTime.Parse(tempdate);
            }
            catch (exception e) {
                System.Writeline(e);
            }
            System.Console.Write("Please enter Time of Entry: ");
            var tempTime = Console.ReadLine(); 
            time = DateTime.Parse(tempTime);

            System.Console.Write("Please enter Duration of visit: ");
            minutes = Console.ReadLine();

            List<People> peoples = new List<People>();
            Classroom newclassroom = new Classroom(roomno, peoples);

            People newperson = new People(name, date, time, minutes);

            newclassroom.Add(newperson);

        }
    }
}
