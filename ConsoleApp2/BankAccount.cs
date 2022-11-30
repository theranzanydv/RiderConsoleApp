using System.Text;

namespace ConsoleApp2;

public class BankAccount
{
    public string Number { get; } = null!;
    public string Owner { get; set; }

    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }

    private static int _accountNumberSeed = 123456789;
    private static List<Transaction> _allTransactions = new List<Transaction>();

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "initial deposit");
        Number = _accountNumberSeed.ToString();
        _accountNumberSeed++;
    }


    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit should me a positive value");
        }

        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawl(decimal amount, DateTime date, string note)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl should me a positive value");

        if ((Balance - amount) < 0) throw new InvalidOperationException("You do not have sufficient balance");

        var withdraw = new Transaction(-amount, date, note);
        _allTransactions.Add(withdraw);
        Console.WriteLine($"Transaction worth of £{amount} has been done through your account");
    }


    public string GetAccountReport()
    {
        StringBuilder report = new StringBuilder();
        // HEADER
        report.AppendLine("=========================================================");
        report.AppendLine("Date\t\t\tAmount\tNote");
        report.AppendLine("---------------------------------------------------------");

        foreach (var item in _allTransactions)
        {
            // ROWS   
            report.AppendLine($"{item.Date.ToShortDateString()}\t\t£ {item.Amount}\t{item.Note}");
        }
        report.AppendLine("\n=========================================================");


        return report.ToString();
    }
}