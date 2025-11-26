
////Task1
//using System;

//namespace Workshop5
//{
//    class Program
//    {
//        static void Main()
//        {
//            BankAccount acc = new BankAccount("12345", 500);

//            Console.WriteLine("Account Number: " + acc.AccountNumber);
//            Console.WriteLine("Initial Balance: " + acc.Balance);

//            acc.Deposit(300);
//            Console.WriteLine("After Deposit: " + acc.Balance);

//            acc.Withdraw(200);
//            Console.WriteLine("After Withdraw: " + acc.Balance);
//        }
//    }
//}

//Task2

using System;
using System.Runtime.ConstrainedExecution;

namespace Workshop5
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.Brand = "Toyota";
            car.Speed = 120;
            car.Seats = 4;

            Motorcycle moto = new Motorcycle();
            moto.Brand = "Yamaha";
            moto.Speed = 90;
            moto.Type = "Sport";

            Console.WriteLine("Car Info:");
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            Console.WriteLine("Motorcycle Info:");
            moto.Start();
            moto.DisplayInfo();
            moto.Stop();
        }
    }
}



