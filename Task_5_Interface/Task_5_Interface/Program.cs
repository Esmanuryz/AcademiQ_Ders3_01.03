using Task_5_Interface;



class Program
{
    static void Main()
    {

        //ornek 1
        Bilgisayar bilgisayar = new Bilgisayar();
        bilgisayar.Ac();
        bilgisayar.Kapat();


        //ornek 2
        Marti marti = new Marti();
        marti.Uc();
        marti.Yuz();
    }
}