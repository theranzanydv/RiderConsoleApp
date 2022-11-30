namespace ConsoleApp.Week4;

public class Bank
{
    public Bank(string number, string owner, decimal balance)
    {
        Number = number ?? throw new ArgumentNullException(nameof(number));
        Owner = owner ?? throw new ArgumentNullException(nameof(owner));
        Balance = balance;
    }

    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }


    public void MakeDeposit(decimal amount,DateTime date , string note)
    {
        
    }
}