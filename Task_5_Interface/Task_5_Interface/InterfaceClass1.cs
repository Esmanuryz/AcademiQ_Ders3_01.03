using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Interface
{
   
    interface ICihaz
    {
        void Ac();
        void Kapat();
    }

    class Bilgisayar : ICihaz
    {
        public void Ac()
        {
            Console.WriteLine("Bilgisayar açılıyor...");
        }

        public void Kapat()
        {
            Console.WriteLine("Bilgisayar kapanıyor...");
        }
    }

    
           
     

}
