using System;
using Acount.Entities;

namespace Acount
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "alex", 500.0);
            Account acc2 = new Account(1002, "Anna", 500.0);

            acc1.WithDraw(10);
            acc2.WithDraw(20);
            

            Account acc3 = new SavingAccount(1002, "Anna", 500.0, 0.01);

            acc3.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc3.Balance);
            
        }
    }
}
