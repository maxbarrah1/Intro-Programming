using System;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double  pnum = 1;
            Console.WriteLine("Input Base number:");
            string a = Console.ReadLine();
            int c = int.Parse(a);
            Console.WriteLine("Input the Exponent:");
            string b = Console.ReadLine();
            int d = int.Parse(b);

            int result = (c * d);


            if (c > 0){
                for (int i = d; i>0; i--)
                    pnum = pnum * c;
            }
            else if(d < 0){
            
                for(int i=d; i<0; i++)
                    pnum = pnum/c;
            }
            
            Console.WriteLine("{0} Raised to the Power of {1} is {2}", a, b, pnum);
            
        }
    }
}
