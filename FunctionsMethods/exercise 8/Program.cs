using System;

namespace exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0;
            int num2=1;
            int sum;
            int input;
            int i;
            
        
            Console.Write("Input number of terms to be display in the fibonacci seqence: ");
            input = Convert.ToInt32(Console.ReadLine());    
            Console.Write("Here is the fibonacci series up to  to {0} terms: \n",input);
            Console.Write("{0}    {1}", num1,num2);
            
            for(i=3;i<=input;i++)
            {
                sum=num1+num2;
                Console.Write("  {0}  ",sum);
                num1=num2;
                num2=sum;
            }
            Console.Write("\n");
          }
     }
}
