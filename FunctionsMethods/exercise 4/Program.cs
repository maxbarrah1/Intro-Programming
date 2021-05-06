using System;

namespace exercise_4
{
    class Program
    
        
    {
           public static void Main() {
            int counter = 0;
            Console.WriteLine("this program will count the amount of spaces in a sentence");
            Console.WriteLine("enter a sentence:");
            string sentence = Console.ReadLine();

            for (int i = 0;i < sentence.Length;i++){
                sentence = sentence.Substring(i,1);
			  if (sentence == " "){
					counter++;
              }
            }
        
            
            Console.WriteLine("\""+sentence+"\""+" contains " +counter+ " spaces" );
            }
        
    }
}
