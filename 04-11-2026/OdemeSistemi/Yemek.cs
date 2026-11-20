using System;
using System.Collections.Generic;
using System.Text;

namespace OdemeSistemi
{
    internal class Yemek
    {        
        public string Name { get; set; }
        public double Fiyat { get; set; }
        public int Porsiyon { get; set; }
        public int SiparisAdedi { get; set; }
        public Yemek(string name, double fiyat, int porsiyon)
        {
            Name = name;
            Fiyat = fiyat;
            Porsiyon = porsiyon;
        }


        public override string ToString()
        {
            return $"Yemek Adı: {Name}, Fiyat: {Fiyat:c2}, Mevcut Porsiyon: {Porsiyon}";
        }
    }
}
