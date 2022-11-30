using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week3
{
    internal class SwapNumbers
    {
        public void Main(int number1, int number2)
        {
            Console.WriteLine("The Given Numbers are :\t\t [" + number1 + "," + number2 + "]");
            // Primitive Way   
            // int temp = Number1;
            // Number1 = Number2;
            // Number2 = temp;

            // New way of swapping numbers
            (number1, number2) = (number2, number1);
            Console.WriteLine("The Swapped Numbers are:\t [" + number1 + "," + number2 + "]");
        }
    }
}