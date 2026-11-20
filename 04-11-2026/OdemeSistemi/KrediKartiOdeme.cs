using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class KrediKartiOdeme : OdemeYontemi
    {
        public static int KrediKartiOdemeSayisi;
        public KrediKartiOdeme(double tutar) : base(tutar)
        {
        }

        public override bool OdemeYap()
        {
            Logla();
            Console.WriteLine("Kredi kartından çekim yapıldı.");
            IslemiTamamla();
            KrediKartiOdemeSayisi++;
            return true;
        }
    }
}
