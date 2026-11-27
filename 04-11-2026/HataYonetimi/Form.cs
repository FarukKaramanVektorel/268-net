using System;
using System.Collections.Generic;
using System.Text;

namespace HataYonetimi
{
    internal class Form
    {
        public string Name { get; set; }
		private int _yas;

        public Form(string name, int yas)
        {
            Name = name;
            Yas = yas;
        }

        public int Yas
		{
			get { return _yas; }
			set {
				if (value < 18)
				{
					throw new GecersizYasException(value,"Çocuk işçi çalıştırmıyoruz");
				}else if(value > 45)
				{
                    throw new GecersizYasException(value, "Mezarda emekliliğe hayır");
                }
				else
				{
					_yas = value;
				}
			
			}
		}

	}
}
