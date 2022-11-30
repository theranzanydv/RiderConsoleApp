using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week3
{
    internal class PrimeNumber
    {

        //public int Number =0;
        public void Prime(int Number)
        {
            byte count = 0;
            for (int i = 1; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("{0} is a Prime Number", Number);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", Number);
            }

        }

    }
}