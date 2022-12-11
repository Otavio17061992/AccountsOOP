using System;
using System.Collections.Generic;
using System.Text;

namespace Acount.Entities
{
    class SavingAccount : Account
    {
        public double InteresRate { get; set; }


        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interesRate) 
            :base(number,holder,balance)
        {
            InteresRate = interesRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        public override void WithDraw(double amount)
        {
            base.WithDraw(amount);

            Balance -= 2.0;
        }
    }
}
