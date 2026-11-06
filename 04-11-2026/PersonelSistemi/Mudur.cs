using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelSistemi
{
    internal class Mudur : PersonelBase
    {
        public static int CountM { get; set; }
        public Mudur(string name) : base(name)
        {
            CountM++;
        }

        public double MudurMaasHesapla()
        {
            double maas = Maas() * 3;
            TotalMaas += maas;
            return maas;
        }
    }
}
