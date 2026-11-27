using System;
using System.Collections.Generic;
using System.Text;

namespace HataYonetimi
{
    internal class GecersizYasException:Exception
    {
        public int yas { get; }
        public GecersizYasException(int yas, string message):base(message) 
        {
            this.yas = yas;
        }

      


    }
}
