using System;
using System.Collections.Generic;

namespace Classes_OO
{
    public class Program
    {
      static void Main(string[] args)
      {
        List<colour> colours = new List<colour>();
        colour red = new colour("13", "31", "35", "Red");
        colours.Add(red);

         List<cookie> cookies = new List<cookie>();
       cookie c1 = new cookie ("Circle", 200, red);
       cookie c2 = new cookie ("Square", 100, red);
       cookie c3 = new cookie ("Rectangle", 300, red);
       cookie c4 = new cookie ("Hexagon", 500, red);
        cookies.Add(c1);
        cookies.Add(c2);
        cookies.Add(c3);
        cookies.Add(c4);

        System.Console.WriteLine(c1.colourName.colourname);


      }



        
        
        
     

    }
}
