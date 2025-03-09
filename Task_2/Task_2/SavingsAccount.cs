using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class SavingsAccount :BankAccount
    {

        // vadeli hesap 

        // CalculateInterest() metodunu override ediniz ve bakiyenin %5’ini faiz olarak hesaplayınız.
        public override void CalculateInterest()
        {
            Balance += Balance * 0.05;
        }
    }
}
