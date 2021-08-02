using System.Collections.Generic;
using System;
namespace week1.models

{
    public class Beehive
    {
        

       
        public int MaxBees { get; set; }
        public List<Bee> Bees { get; set; }
        
        public Beehive(int maxbees, List<Bee> bees)
        {
            
            this.MaxBees = maxbees;
            this.Bees = new List<Bee>();
            
        }

        public void CollectHoney() {
            int days = 10;
            float size = 0;
            foreach (var b in Bees) {
                size  += b.Size; 
            }
            double amount = days * size * 0.2;
            
            Console.WriteLine($"the amount of honey collected is {amount}");

        }
    }
}