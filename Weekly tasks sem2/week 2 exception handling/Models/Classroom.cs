using System.Collections.Generic;
namespace week_2_exception_handling.Models
{
    public class Classroom
    {
        

        string Roomid {get; set;}
        public List<People> Peoples { get; set;}
        public Classroom(string roomid, List<People> peoples)
        {
            Roomid = roomid;
            this.Peoples = new List<People>();
        }
    }
}