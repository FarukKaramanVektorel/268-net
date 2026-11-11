using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class Input
    {
        public static int sayiAl(string message)
        {
            Console.WriteLine(message);
            int.TryParse(Console.ReadLine(), out int sayi);
            return sayi;
        }
        public static decimal decimalAl(string message)
        {
            Console.WriteLine(message);
            decimal.TryParse(Console.ReadLine(), out decimal sayi);
            return sayi;
        }

        public static double doubleAl(string message)
        {
            Console.WriteLine(message);
            double.TryParse(Console.ReadLine(), out double sayi);
            return sayi;
        }
        public static bool boolAl(string message)
        {
            Console.WriteLine(message);
            bool.TryParse(Console.ReadLine(), out bool sayi);
            return sayi;
        }

        public static string stringAl(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()??"";
        }

    }
}
