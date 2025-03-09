using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class CheckingAccount : BankAccount
    {

        // vadesiz hesap
        // CalculateInterest() metodunu override ediniz ve "Checking accounts do not earn interest." mesajı veriniz.
        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }

    }
}
