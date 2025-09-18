using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserÖvningsuppgifter
{
    internal class MathHelper
    {
        //Properties
        public int Number1 { get; set; }
        public int Number2 { get; set; }


        //Konstruktör
        public MathHelper(int Number1, int Number2)
        {
            this.Number1 = Number1;
            this.Number2 = Number2;
        }

        //Metoder
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            return (double)a / b;
        }

    }
}
