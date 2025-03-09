using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Abstract
{
   

abstract class Calisan
    {
        public string Ad { get; set; }

        public Calisan(string ad)
        {
            Ad = ad;
        }

        public abstract void Calis();
    }

    class Muhendis : Calisan
    {
        public Muhendis(string ad) : base(ad) { }

        public override void Calis()
        {
            Console.WriteLine($"{Ad} mühendis olarak çalışıyor.");
        }
    }


}
