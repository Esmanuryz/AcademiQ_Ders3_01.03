using System;
using Task_5_Abstract;

class Program
{
    static void Main()
    {
        // Example 1 output
        Araba araba = new Araba();
        araba.Hizlan();
        araba.Dur();

        // Example 2 output
        Muhendis muhendis = new Muhendis("Ahmet");
        muhendis.Calis();
    }
}