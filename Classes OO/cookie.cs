namespace Classes_OO
{
    public class cookie
    {
         //attributes
         public string shape;
         public int weight;

        public colour colourName;

         //constructor
         public cookie (string shape, int weight, colour anything)
         {
             this.shape = shape;
             this.weight = weight;
             this.colourName = anything;
         }
    }
}