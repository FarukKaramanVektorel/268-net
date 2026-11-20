using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class Paketci
    {
        public string Name { get; set; }
        public int PaketSayisi;
        public Paketci(string name)
        {
            Name = name;
        }
        public void PaketTeslimet(Siparis siparis)
        {
            Console.WriteLine($"Ben kuryeniz {Name}, {siparis.Adress} adresine geldim, siparişlerinizi getirdim.");
            double tutar = SiparisListele(siparis);
            OdemeAl(tutar);

        }

        private void OdemeAl(double tutar)
        {
            Console.WriteLine($"Ödemeniz gereken toplam tutar: {tutar:c2}");
            int odeme = Util.SayiAl("Ödemenizi Nasıl Yapmak İstersiniz?\n1-Kredi Kartı\n2-Havale/EFT");
            if (odeme == 1)
            {
                KrediKartiOdeme ko = new KrediKartiOdeme(tutar);
                ko.OdemeYap();
            }
            else if (odeme == 2)
            {
                HavaleOdeme ho = new HavaleOdeme(tutar);
                ho.OdemeYap();
            }
            else
            {
                Console.WriteLine("Müşteri dövülerek hesap tahsil edildi...");
            }

        }

        private double SiparisListele(Siparis siparis)
        {
            double total = 0;
            foreach (var item in siparis.Yemek)
            {
                double araToplam = item.SiparisAdedi * item.Fiyat;
                Console.WriteLine($"{item.Name} yemeğinden, {item.SiparisAdedi} aldınız, Tutar: {araToplam} ");               
                total += araToplam;
            }
            return total;
        }
    }
}
