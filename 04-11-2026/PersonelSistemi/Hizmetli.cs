using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelSistemi
{
    internal class Hizmetli : PersonelBase
    {
        public static int CountH { get; set; }
        public Hizmetli(string name) : base(name)
        {
            CountH++;
        }

        public double MaasHesapla()
        {
            TotalMaas += Maas();
            return Maas();
        }
    }
}
