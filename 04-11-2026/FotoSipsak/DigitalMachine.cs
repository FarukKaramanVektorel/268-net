using System;
using System.Collections.Generic;
using System.Text;

namespace FotoSipsak
{
    internal class DigitalMachine : FotoMachine
    {
        public bool IsFlashOpen { get; set; }

        public DigitalMachine(bool isFlashOpen, string model, Batarya batery) : base(model, batery)
        {
            IsFlashOpen = isFlashOpen;
        }


        public override void TakeFoto(string manzara)
        {
            if (IsFlashOpen && Batery.IsHeight(3))
            {
                Batery.PowerMinus(2);
                Console.WriteLine($"{manzara} fotoğrafı çekildi");
            }
            else if (!IsFlashOpen && Batery.IsHeight(1))
            {
                Batery.PowerMinus(1);
                Console.WriteLine($"{manzara} fotoğrafı çekildi");
            }
            else
            {
                Console.WriteLine("pil bitti batarya değişmen lazım acilen...."+Batery.Power);
            }
        }
    }
}
