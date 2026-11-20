using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class HavaleOdeme : OdemeYontemi
    {
        public static int HavaleOdemeSayisi;
        public HavaleOdeme(double tutar) : base(tutar)
        {
        }

        public override bool OdemeYap()
        {
            Logla();
            Console.WriteLine("Havale/EFT ile ödeme alındı.");
            IslemiTamamla();
            HavaleOdemeSayisi++;
            return true;
        }
    }
}
