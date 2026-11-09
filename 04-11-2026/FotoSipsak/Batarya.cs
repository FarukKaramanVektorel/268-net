using System;
using System.Collections.Generic;
using System.Text;

namespace FotoSipsak
{
    internal class Batarya
    {

        public string Marka { get; set; }

        public int Power { get; set; }

        public Batarya(string marka, int power)
        {
            Marka = marka;
            Power = power;
        }

        public void PowerMinus(int power)
        {
            if (IsHeight(power))
            {
                Power -= power;
                Console.WriteLine($"{Marka} {power} eksildi");
            }
            else
            {
                Console.WriteLine("Pil tükendi ben tükendim");
            }
        }

        public bool IsHeight(int power)
        {
            return Power-power >=0;
        }
        public override string ToString()
        {
            return $"Marka: {Marka}, Güç: {Power}";
        }

    }
}
