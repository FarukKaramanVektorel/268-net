using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class Util
    {
        public static string MetinAl(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine()??"Okunamadı";
        }

        public static double DoubleAl(string message)
        {
            Console.WriteLine(message);
            double.TryParse(Console.ReadLine(), out double result);
            return result;
        }
        public static int SayiAl(string message)
        {
            Console.WriteLine(message);
            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }
    }
}
