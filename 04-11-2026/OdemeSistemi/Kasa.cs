using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class Kasa
    {
        public static void Start(Yemek[] yemekler)
        {
            Console.WriteLine("Abuzer Köfte Gezegenine Hoş Geldiniz");
            while (true)
            {
                int islem = Util.SayiAl("İşlem Seçiniz\n1-Sipariş\n2-Menü Listele\n3-Çıkış");
                switch (islem)
                {
                    case 1:SiparisAl(yemekler); break;
                    case 2:MenuListele(yemekler); break;
                    case 3: break;
                    default: Console.WriteLine("Tanımsız işlem girdiniz"); break;
                }
            }
        }

        private static void MenuListele(Yemek[] yemekler)
        {
            foreach (var item in yemekler)
            {
                if (item.Porsiyon > 0)
                {
                    Console.WriteLine(item);
                }   
            }
        }

        private static Siparis SiparisAl(Yemek[] yemekler)
        {
            Siparis spr = new Siparis();
            Yemek[] siparisYemekler=new Yemek[0];
            foreach (var item in yemekler)
            {
                if (item.Porsiyon > 0)
                {
                    Console.WriteLine(item);
                    int adet = Util.SayiAl("Kaç adet sipariş vermek istyorsunuz???");
                    if (adet <= item.Porsiyon)
                    {                      
                        Array.Resize(ref siparisYemekler, siparisYemekler.Length + 1);                      
                        siparisYemekler[siparisYemekler.Length - 1]= item;
                        item.SiparisAdedi = adet;
                    }
                }
            }
            spr.Yemek=siparisYemekler;
            spr.Adress = Util.MetinAl("Adres yazınız");
            return spr;

        }
    }
}
