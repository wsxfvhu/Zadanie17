using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<string> account1 = new Account<string>("0000001", 1000, "Василий", "Перов");
            account1.Deposit(10);
            account1.Withdraw(20);
            account1.Print();
            Account<int> account2 = new Account<int>(256, 1000, "Пётр", "Второв");
            account2.Deposit(50);
            account2.Withdraw(100);
            account2.Print();
            Console.ReadKey();

        }
        class Account<T>
        {
            private T num;
            private decimal balance;
            private string firstName;
            private string lastName;
            public string Name
            {
                get { return $"{firstName} {lastName}"; }
            }
            public Account(T num, decimal balance, string firstName, string lastName)
            {
                this.num = num;
                Balance = balance;
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public T Num { get => num; }
            public decimal Balance { get => balance; private set => balance = value; }
            public void Print()
            {
                Console.WriteLine($"Номер счета - {num}");
                Console.WriteLine($"Владелец - {Name}");
                Console.WriteLine($"Баланс - {Balance}");
                Console.WriteLine();
            }
            public void Withdraw(decimal money)
            {
                Balance -= money;
            }
            public void Deposit(decimal money)
            {
                Balance += money;
            }
        }
    }
}
