using System;
using System.Collections.Generic;
using System.Text;

namespace WarCharacter
{
    internal class Nation
    {
       
       
        public string Name { get; set; }
        private double _power;

        public double Power
        {
            get { return _power; }
            set {
                if (value <= 0 || value > 10)
                {
                    Console.WriteLine("Sınırların içerisinde kalınız");
                    _power = 1;
                }
                else
                {
                    _power = value;
                }
            }
        }

        public Nation(string name, double power)
        {
            Name = name;
            Power = power;
        }

    }
}
