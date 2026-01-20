using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Me me = new Me();
            Console.WriteLine("Оберіть, яку інформацію показати:");
            Console.WriteLine("1 - ПІБ");
            Console.WriteLine("2 - Місто та адреса");
            Console.WriteLine("3 - Курс");
            Console.Write("Ваш вибір: ");

            string? choice = Console.ReadLine();

            if (choice == "1")
                me.ShowPIBInfo();
            else if (choice == "2")
                me.ShowAddressInfo();
            else if (choice == "3")
                me.ShowKYRSInfo();
            else
                Console.WriteLine("Невірний вибір");

            Console.WriteLine("Натисніть Enter, щоб завершити...");
            Console.ReadLine();
        }
    }
}