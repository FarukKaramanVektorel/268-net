using System;
using System.Collections.Generic;
using System.Text;

namespace FotoSipsak
{
    internal class FotoMachine
    {


        public string Model { get; set; }
        public Batarya Batery { get; set; }

        public FotoMachine(string model, Batarya batery)
        {
            Model = model;
            Batery = batery;
        }

        public virtual void TakeFoto(string manzara)
        {
            if (!Batery.IsHeight(1))
            {
                Console.WriteLine("Harç bitti yapı paydos, Batarya durumu: " + Batery);
                return;
            }
            Console.WriteLine($"{manzara} fotoğrafı çekildi");
            Batery.PowerMinus(1);
        }
        public bool ChangeBatery(ref Batarya batery)
        {
            if (batery.IsHeight(5))
            {
                Console.WriteLine($"{Batery}, {batery} ile değiştirildi");
                Batery = batery;
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            return $"Model: {Model}, Batarya: {Batery}";
        }

    }
}
