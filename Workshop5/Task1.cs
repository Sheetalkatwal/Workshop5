//namespace Workshop5
//{
//    class BankAccount
//    {
//        private string accountNumber;
//        private double balance;

//        public string AccountNumber
//        {
//            get { return accountNumber; }
//        }

//        public double Balance
//        {
//            get { return balance; }
//            private set
//            {
//                if (value > 0)
//                {
//                    balance = value;
//                }
//            }
//        }

//        public BankAccount(string accNum, double initialBalance)
//        {
//            accountNumber = accNum;
//            if (initialBalance > 0)
//            {
//                balance = initialBalance;
//            }
//        }

//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//            }
//            else
//            {
//                Console.WriteLine("Invalid deposit amount.");
//            }
//        }

//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= balance)
//            {
//                balance -= amount;
//            }
//            else
//            {
//                Console.WriteLine("Invalid withdraw amount.");
//            }
//        }
//    }
//}

