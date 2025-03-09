using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class BankAccount
    {

        // AccountHolder , Balance
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public virtual void CalculateInterest()
        {

        }
    }
}
