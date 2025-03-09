using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_Interface
{
    
    interface IUcabilir
    {
        void Uc();
    }

    interface IYuzebilir
    {
        void Yuz();
    }

    class Marti : IUcabilir, IYuzebilir
    {
        public void Uc()
        {
            Console.WriteLine("Martı uçuyor...");
        }

        public void Yuz()
        {
            Console.WriteLine("Martı yüzüyor...");
        }
    }

  

}
