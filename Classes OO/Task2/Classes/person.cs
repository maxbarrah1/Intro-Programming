using System;
using System.Collections.Generic;
namespace Task2.Classes
{
    public class person
    {
        

        public string firstname { get; set; }

        public string surname { get; set; }

        public int height { get; set; }

        public DateTime dob { get; set; }
        
        public int id { get; set;}
        
        public List<subject> subject = new List<subject>();

        public person(string firstname, string surname, int height, DateTime dob)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.height = height;
            this.dob = dob;
            
        }

        public string GetFullName() {
            return firstname + surname;
        }

        public int GetHeightDifference(person people) {
            return people.height - this.height;
        }

        private int Createid() {
            Random num = new Random();
            int idnumber = num.Next(100,999);
            return idnumber;
        }

        internal void Addsubject(subject subject)
        {
            throw new NotImplementedException();
        }

        public void Getsubject() {
                foreach(var s in this.subject){
                    s.WriteSubject();
                }
        }
        
        
        public void Setgrade(string name, string grade) {
                foreach (var s in this.subject) {
                    if(s.name == name)
                        s.grade = grade; 
                    }
        }
                
        
                
    }
}