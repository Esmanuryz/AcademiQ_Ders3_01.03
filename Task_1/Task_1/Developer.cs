using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Developer : Employee
    {

        // About
        public string About { get; set; }

        /*Yöneticiler maaşlarının %20’sini prim olarak almalıdır.
          Geliştiriciler maaşlarının %10’unu prim olarak almalıdır.
        */
        public override void CalculateBonus()
        {
            Salary += Salary * 0.1;
            Console.WriteLine("Developer Bonus: " + Salary);
        }

    }
}
