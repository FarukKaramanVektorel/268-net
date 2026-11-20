using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal abstract class OdemeYontemi:ILoglanabilir
    {
        public static int ToplamIslemSayisi;       

        public double Tutar { get; set; }
        protected OdemeYontemi(double tutar)
        {
            Tutar = tutar;
        }
        public void Logla()
        {
            Console.WriteLine($"[LOG] {GetType().Name}: {Tutar:C2} işleniyor...");
        }
        protected void IslemiTamamla()
        {
            ToplamIslemSayisi++;
        }

        public abstract bool OdemeYap();
    }
}
