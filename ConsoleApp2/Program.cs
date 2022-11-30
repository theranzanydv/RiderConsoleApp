using ConsoleApp2;

BankAccount account = new BankAccount("Ranjan Yadav", (130));
Console.WriteLine(
    $"An account '{account.Number}' was created for {account.Owner} with a balance of £{account.Balance}");

account.MakeWithdrawl(10, DateTime.Now, "Flower");
Console.WriteLine($"The remaining balance in the account is £{account.Balance}\n");

// Checking exception handler by providing negative deposit value
// account.MakeDeposit(-10, DateTime.Now, "fuck");

// Checking exception by withdrawing more amount than present in the account
// account.MakeWithdrawl(150, DateTime.Now, "Car");

Console.WriteLine(account.GetAccountReport());


// try
// {
//     BankAccount invalidAccount = new BankAccount("Apple Pie", -1000);
// }
// catch (ArgumentOutOfRangeException e)
// {
//     Console.WriteLine(e.ToString());
//     throw;
// }