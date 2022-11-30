using ConsoleApp;

Console.WriteLine("\nChoose one of the Numbers below:");
Console.WriteLine("1. Check whether a Number is Prime");
Console.WriteLine("2. Check whether a Number is Odd or Even");
Console.WriteLine("3. Swap two Numbers");
Console.WriteLine("4. Search inside an Array of String");

Console.Write("\nEnter a number from above\t: ");
string? input1 = Console.ReadLine();
input1 = string.IsNullOrEmpty(input1) ? "0" : input1;
int inputInt = Convert.ToInt32(input1);

switch (inputInt)
{
    case 1:
        SwitchFunctions.FindPrime();
        break;
    case 2:
        SwitchFunctions.OddEven();
        break;
    case 3:
        SwitchFunctions.SwapVariables();
        break;
    case 4:
        SwitchFunctions.FindInArray();
        break;
    default:
        Console.WriteLine("No Value Entered");
        break;
}