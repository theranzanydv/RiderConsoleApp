using ConsoleApp.Week3;

namespace ConsoleApp
{
    internal static class SwitchFunctions
    {
        public static void FindPrime()
        {
            Console.WriteLine("Selected => 1\nCheck if a Number is Prime or Not");
            Console.Write("Enter a number : ");
            string? input2 = Console.ReadLine();
            input2 = string.IsNullOrEmpty(input2) ? "0" : input2;
            int primeInput = Convert.ToInt32(input2);
            PrimeNumber p = new();
            p.Prime(primeInput);
        }

        public static void OddEven()
        {
            Console.WriteLine("Selected => 2\nCheck if a number is Odd or Even");
            Console.Write("Enter a number : ");
            string? input3 = Console.ReadLine();
            input3 = string.IsNullOrEmpty(input3) ? "0" : input3;
            int oddEvenInput = Convert.ToInt32(input3);
            OddEven oe = new();
            oe.IsOdd(oddEvenInput);
        }

        public static void SwapVariables()
        {
            Console.WriteLine("Selected => 3\nSwap the given two numbers");
            Console.Write("Enter number 1 : ");
            string? input4 = Console.ReadLine();
            input4 = string.IsNullOrEmpty(input4) ? "0" : input4;
            int a = Convert.ToInt32(input4);
            Console.Write("Enter number 2 : ");
            string? input5 = Console.ReadLine();
            input5 = string.IsNullOrEmpty(input5) ? "0" : input5;
            int b = Convert.ToInt32(input5);
            SwapNumbers s = new();
            s.Main(a, b);
        }

        public static void FindInArray()
        {
            Console.WriteLine("Selected => 4\nSearch a term in an array");
            Console.Write("Enter to term to search : ");
            string? term = Console.ReadLine();
            term = string.IsNullOrEmpty(term) ? "Apple" : term;
            ArraySearch search = new();
            search.SearchTerm(term);
        }
    }
}