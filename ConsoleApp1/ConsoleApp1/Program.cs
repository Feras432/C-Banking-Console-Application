// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

BankAccount account = new("", 0, 0.0);

Console.WriteLine("Welcome to the Basic Banking Application 🏦\n");
Console.WriteLine("--------------------------------------\r\n");
Console.Write("Please enter your name: ");
account.Name = Console.ReadLine();

Console.Write("Enter your account number: ");
account.AccountNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your initial deposit: ");
account.Balance =  Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n\nAccount setup successsful!\n");
double[] transactionHistory = new double[5];

int index = 0;
printMenu();

int option = Convert.ToInt32(Console.ReadLine());
while (option >= 1 && option <= 4)
{  
    if (option == 1)
    {
        Console.Write("Please enter the amount you want to deposit: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        transactionHistory[index] = amount;
        index++;
        account.Balance = Deposit(account.Balance, amount);

    }else if (option == 2)
    {
        Console.Write("Please enter the amount you want to withdraw:");
        double amount = Convert.ToDouble(Console.ReadLine());
        transactionHistory[index] = amount;
        index++;
        account.Balance = Withdraw(account.Balance, amount);

    }else if (option == 3)
    {
        GetBalance(account.Balance);
        
    }else if (option == 4)
    {
        ListTransactions(transactionHistory);
    }
   
    printMenu();
    option = Convert.ToInt32(Console.ReadLine());
};



 void printMenu()
{
    Console.WriteLine("Main Menu: \n");
    Console.WriteLine("1. Deposit\n");
    Console.WriteLine("2. Withdraw\n");
    Console.WriteLine("3. View Balance\n");
    Console.WriteLine("4. List Transactions\n");
    Console.WriteLine("5. Exit\n");
    Console.WriteLine("Please select an option\n");
    
}
double Deposit(double balance, double amount)
{
    return balance += amount;
}

double Withdraw(double balance, double amount)
{
    return balance -= amount;
}

void GetBalance(double balance)
{
    Console.WriteLine($"Balance: {balance}\n");
}

void ListTransactions(double[] transactionHistory)
{
    foreach (var item in transactionHistory)
    {
        Console.WriteLine(item.ToString());
    }

}
