using System;

namespace Code_wars
{
    class Program
    {
        static Number number = new Number();
        static void Main(string[] args)
        {
            //Console.WriteLine(number.DigitalRoot(16));
            //Console.WriteLine(number.find_it(new[] { 2,2 }));
            int[] x = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] y = { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
            Console.WriteLine(number.AreTheySame(x,y));


        }
    }
}
