using System.Collections.Generic;
using System;
namespace week_2_exception_handling.Models

{
    public class People
    {
        string Name {get; set;}
        DateTime Dateentered {get; set;}
        DateTime Timeentered {get; set;}
        int Duration {get; set;}
        public People(string name, DateTime dateentered, DateTime timeentered, int duration)
        {
            this.Name = name;
            this.Dateentered = dateentered;
            this.Timeentered = timeentered;
            this.Duration = duration;
        }
    }
}