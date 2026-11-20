using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class Kasa
    {
        public static Paketci kurye = new Paketci("Abdurrahman");
        public static void Start(ref Yemek[] yemekler)
        {
            Siparis siparis = new Siparis();
            Console.WriteLine("Abuzer Köfte Gezegenine Hoş Geldiniz");
            bool dongu = true;
            while (dongu)
            {
                int islem = Util.SayiAl("İşlem Seçiniz\n1-Sipariş\n2-Menü Listele\n3-Çıkış");
                switch (islem)
                {
                    case 1:
                        {
                            siparis = SiparisAl(ref yemekler);
                            break;
                        }
                    case 2: MenuListele(yemekler); break;
                    case 3: dongu = false; break;
                    default: Console.WriteLine("Tanımsız işlem girdiniz"); break;
                }
            }

            if (siparis.Yemek.Length > 0&&siparis!=null)
            {
                kurye.PaketTeslimet(siparis);
            }
        }



        private static void MenuListele(Yemek[] yemekler)
        {
            foreach (var item in yemekler)
            {
                if (item.Porsiyon > 0)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(500);
                }
            }
        }

        private static Siparis SiparisAl(ref Yemek[] yemekler)
        {
            if (!siparisKontrol(yemekler, true))
            {
                return null;
            }
                Siparis spr = new Siparis();
            Yemek[] siparisYemekler = new Yemek[0];
            foreach (var item in yemekler)
            {
                if (item.Porsiyon > 0)
                {
                    Console.WriteLine(item);
                    int adet = Util.SayiAl("Kaç adet sipariş vermek istyorsunuz???");
                    if (adet <= item.Porsiyon && adet > 0)
                    {
                        Array.Resize(ref siparisYemekler, siparisYemekler.Length + 1);
                        elemanAta(item, ref siparisYemekler);
                        item.SiparisAdedi = adet;
                        item.Porsiyon -= adet;
                    }
                    else if (adet > item.Porsiyon)
                    {
                        Console.WriteLine($"{adet} porsiyon {item.Name} yemeğimiz maalesef yok...");
                    }
                }
            }
            spr.Yemek = siparisYemekler;
            if (siparisKontrol(spr.Yemek, false))
            {                
                spr.Adress = Util.MetinAl("Adres yazınız");
                return spr;
            }
            return null;


        }

        private static bool siparisKontrol(Yemek[] ymk, bool type)
        {
            int count = 0;
            if (type)
            {
                foreach (var item in ymk)
                {
                    count += item.Porsiyon;
                }
            }
            else
            {
                foreach (var item in ymk)
                {
                    count += item.SiparisAdedi;
                }
            }
            return count > 0;
        }

        private static void elemanAta(Yemek item, ref Yemek[] siparisYemekler)
        {
            siparisYemekler[siparisYemekler.Length - 1] = item;
        }
    }
}
