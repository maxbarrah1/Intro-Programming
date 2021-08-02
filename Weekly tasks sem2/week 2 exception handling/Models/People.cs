using System.Collections.Generic;
namespace week_2_exception_handling.Models
{
    public class People
    {
        string Name {get; set;}
        datetime Dateentered {get; set;}
        datetime Timeentered {get; set;}
        int Duration {get; set;}
        public People(string name, datetime dateentered, datetime timeentered, int duration)
        {
            this.Name = name;
            this.Dateentered = dateentered;
            this.Timeentered = timeentered;
            this.Duration = duration;
        }
    }
}