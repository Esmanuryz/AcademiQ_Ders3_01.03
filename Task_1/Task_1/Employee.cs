using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    
    internal class Employee
    {

        //Id,Name,Salary,Department bulunmali

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public virtual void CalculateBonus()
        {
            Console.WriteLine("CalculateBonus Default");
        }

    }
}
