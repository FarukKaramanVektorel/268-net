using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelSistemi
{
    internal class Pazarlama : PersonelBase
    {
		private double _satisTutari;
        public static int CountP { get; set; }

        public Pazarlama(double satisTutari,string name) : base(name)
        {
            SatisTutari = satisTutari;
            TotalSatis += satisTutari;
            CountP++;
            MaasHesapla();
        }

        public double SatisTutari
        {
			get { return _satisTutari; }
			set {
				if (value < 0)
				{
                    Console.WriteLine("Hayırdır kasadan para mı çaldın???");
					_satisTutari = 0;
                }
				else
				{
                    _satisTutari = value;
                }
			}
		}


        public double MaasHesapla()
        {
            double maas=Maas()+SatisTutari*0.1;
            TotalMaas += maas;
            return maas;

        }


	}
}
