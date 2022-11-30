using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week3
{
    internal class OddEven
    {

        //public int Number =0;
        public void IsOdd(int Number)
        {
            if (Number % 2 != 0)
            {
                Console.WriteLine("{0} is an Odd Number", Number);
            }
            else
            {
                Console.WriteLine("{0} is an Even Number", Number);
            }

        }

    }
}
