//Ana sınıfta (Program.cs) nesneler oluşturunuz ve metotları çalıştırınız.

using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BankAccount nesnesi oluşturma
            BankAccount bankAccount = new BankAccount
            {
                AccountHolder = "Ali Veli",
                Balance = 1000
            };

            // SavingsAccount nesnesi oluşturma
            SavingsAccount savingsAccount = new SavingsAccount
            {
                AccountHolder = "Ayşe Yılmaz",
                Balance = 2000
            };

            // Faiz hesaplama metotlarını çağırma
            bankAccount.CalculateInterest();
            savingsAccount.CalculateInterest();

            // Sonuçları yazdırma
            Console.WriteLine($"BankAccount - Hesap Sahibi: {bankAccount.AccountHolder}, Bakiye: {bankAccount.Balance}");
            Console.WriteLine($"SavingsAccount - Hesap Sahibi: {savingsAccount.AccountHolder}, Bakiye: {savingsAccount.Balance}");
        }
    }
}