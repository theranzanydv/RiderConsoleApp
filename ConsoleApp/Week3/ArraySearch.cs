using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week3
{
    internal class ArraySearch
    {
        public void SearchTerm(string Word)


        {

            string[] fruits = { "Apple", "Mango", "Kiwi", "Orange" };
            string value = Word.ToLower();
            //int pos = Array.IndexOf(fruits, value);

            //case insensitive search
            int pos = Array.FindIndex(fruits, t => t.Equals(Word, StringComparison.InvariantCultureIgnoreCase));
            if (pos > -1)
            {
                Console.WriteLine("=== {0} found", Word);
            }
            else
            {
                Console.WriteLine("=== {0} not found", Word);
            }


        }
    }
}