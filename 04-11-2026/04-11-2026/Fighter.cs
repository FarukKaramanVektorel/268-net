using System;
using System.Collections.Generic;
using System.Text;

namespace _04_11_2026
{
    internal class Fighter
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Healt { get; set; }
        private Random rnd = new Random();

        public Fighter(string name, double weight, double height, double healt)
        {
            Name = name;
            Weight = weight; //120
            Height = height; // 190
            Healt = healt;  // 100
        }

       
        public double Attack()
        {
            double attack = Weight * Height * Healt/1000*rnd.NextDouble();
           if(attack>10)
                Console.WriteLine($"{Name} Kritik vuruş: {attack:F2}");
            return attack;
        }
        public bool IsDefance()
        {
            return rnd.NextDouble()>0.60;
        }

        public string Info()
        {
            return $"Dövüşçü Bilgileri Ad: {Name}, Sağlık Durumu: {Healt:F2}";
        }

    }
}
