using week1.models;
using System; 
using System.Collections.Generic;
namespace week1
{
    class Program
    {
        static void Main(string[] args)
        
        
        {
            List<Bee> bees = new List<Bee>();
            bees.Add(new Bee ("John", 3.2f)) ;
            bees.Add(new Bee ("Paul", 2.7f));
            bees.Add(new Bee ("George", 1.1f));
            bees.Add(new Bee ("Ringo", 2.0f));
            var hive1 = new Beehive (10, bees);


            bees.Add(new Bee ("Kurt", 2.3f));
            bees.Add(new Bee ("Dave", 7.4f));
            bees.Add(new Bee ("Krist", 1.5f));
            var hive2 = new Beehive (15, bees);

            while (true) {
                PrintMenu();
                int choice = GetMenuChoice();
                if (choice == 1) {
                    this.AddHive();

                }
                else if (choice == 2) {
                    Console.WriteLine("Honey For Hive 1:");
                    hive1.CollectHoney();

                    Console.WriteLine("Honey For Hive 1:");
                    hive2.CollectHoney();
                }
                else if (choice == 3) {
                    int counter2 = 0;
                    int counter = 0;
                    foreach(var b in hive1.Bees){
                    counter ++;
                }
                    Console.WriteLine($"the amount of bees in hive 1 is {counter}");

                foreach(var b in hive2.Bees){
                    counter2 ++;
                }
                   Console.WriteLine($"the amount of bees in hive 2 is {counter2}");  
                }
                else  {
                    break;
                }
            }


            

        }

        static void PrintMenu() {
            Console.WriteLine("1. Create Hives");
            Console.WriteLine("2. COLLECT Honey");
            Console.WriteLine("3. Report Number Of Bees");

        }

        static int GetMenuChoice() 
        {
            int result = 0;
            while (result < 1 || result > 4) {
                string input = Console.ReadLine();
                Int32.TryParse(input, out result);
                if (result < 1 || result > 4) {
                Console.WriteLine("Invalid input try again.");
                }
            }
            return result;
        }

        public void AddHive() {
            string maxbeesinhive;

            System.Console.Write("Please enter Maximum amount of bees for the hive: ");
            maxbeesinhive = Console.ReadLine();
            List<Bee> bees = new List<Bee>();
            int beeamount = int.Parse(maxbeesinhive); 
            Beehive newhive = new Beehive(beeamount, bees);
            string beename;
            string beesize;

            System.Console.Write("Please enter Bees Name: ");
            beename = Console.ReadLine();
            System.Console.Write("Please enter Bee Size (must be in to decimal value): ");
            beesize = Console.ReadLine();
            float flt1 = float. Parse(beesize);
            Bee newbee = new Bee(beename, flt1);

            newhive.Bees.Add(newbee);

            return;
        }

    

        


    }
}
