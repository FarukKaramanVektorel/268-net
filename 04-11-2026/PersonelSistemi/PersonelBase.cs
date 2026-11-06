using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace PersonelSistemi
{
    internal class PersonelBase
    {
        public string Name { get; set; }
        public static int Count { get; set; }

        public static double TotalMaas = 0;
        public static double TotalSatis = 0;
        public const double ASGARI_UCRET = 28075;

        public PersonelBase(string name)
        {
            Name = name;
            Count++;
        }

        public double Maas()
        {
            return ASGARI_UCRET;
        }
    }
}
