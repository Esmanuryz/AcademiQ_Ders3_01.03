using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Abstract
{
    abstract class Arac
    {
        public abstract void Hizlan();

        public void Dur()
        {
            Console.WriteLine("Araç durdu.");
        }
    }

    class Araba : Arac
    {
        public override void Hizlan()
        {
            Console.WriteLine("Araba hızlanıyor...");
        }
    }
}
