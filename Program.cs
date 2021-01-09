using System;

namespace test1
{
    // Account instance
    // Account class with a decimal instance
    class Account
    {
        public string Name { get; set; }
        private decimal balance;

        // Account2 constructor that recieves two parameters
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set // Can be used only within the class
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        // method that deposits (add) only a valid amount to the balance
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
    }
    class AccountTest
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            // display initial balance of each object
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            // prompt for then read input
            Console.Write("\n Enter deposit amount for account1:");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance \n");
            account1.Deposit(depositAmount); //add to account's 1 balance

            // Display the balances
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            // prompt for then read user input 
            Console.Write("\n Enter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account2's balance \n");
            account2.Deposit(depositAmount);

            // display balances
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

        }
    }
}
