using System;
using System.Collections.Generic;
using System.Text;

namespace _04_11_2026
{
    internal class Ring
    {
        private Random rnd = new Random();
        public void Run(Fighter a,Fighter b)
        {
            if (Math.Abs(a.Weight - b.Weight) > 15) {
                Console.WriteLine("Sence bu dövüş adil mi????");
                return;
            }
            Fighter[] sirali= SiraBelirle(ref a, ref b);
            Round(ref sirali[0], ref sirali[1]);

        }

      


        private void Round(ref Fighter a,ref Fighter b)
        {
            int round = 1;
            while (!IsWinner(ref a, ref b)&&round<=12) {
                Console.WriteLine($"====={round}. RAUND====="); 
                double attackA = a.Attack();
                double attackB = b.Attack();
                bool defanseA = a.IsDefance();
                bool defanseB = b.IsDefance();
                Console.WriteLine($"{a.Name} {attackA:F2} ile saldırıyor");
                if (!b.IsDefance())
                {
                    b.Healt -= attackA;
                    Console.WriteLine($"{b.Name} {attackA:F2} hasarı aldı");
                }
                else
                {
                    Console.WriteLine(b.Name+" atağı savuşturdu");
                }
                if (IsWinner(ref a,ref b)) break;
                Console.WriteLine($"{b.Info()} {attackB:F2} ile saldırıyor");
                if (!a.IsDefance())
                {
                    a.Healt -= attackB;
                    Console.WriteLine($"{a.Name} {attackB:F2} hasarı aldı...");
                }
                else
                {
                    Console.WriteLine(a.Name + " atağı savuşturdu");
                }
                if (IsWinner(ref a, ref b)) break;
               
                round++;
                Console.WriteLine("Dövüşçü Durumları");
                Print(a);
                Print(b);
                Thread.Sleep(1000);
            }
           
            Speeker(ref a, ref b);
        }
        private void Print(Fighter f)
        {
            if (f.Healt > 70)           
                Console.BackgroundColor = ConsoleColor.Green;
            else if(f.Healt>40) 
                Console.BackgroundColor = ConsoleColor.Blue;
            else
                Console.BackgroundColor = ConsoleColor.Magenta;

            Console.WriteLine(f.Info());
            Console.ResetColor();
        }
        private void Speeker(ref Fighter a,ref Fighter b)
        {
            Console.WriteLine("---------MAÇ BİTTİ---------");
            string metin = a.Healt > b.Healt ? a.Name : b.Name;
            Console.WriteLine(a.Info());
            Console.WriteLine(b.Info());
            Console.WriteLine("Kazanan: "+metin);
            
        }
        private bool IsWinner(ref Fighter a,ref Fighter b)
        {
            if (a.Healt<=0|| b.Healt<=0)
                return true;
           
            return false;
        }

        private Fighter[] SiraBelirle(ref Fighter a, ref Fighter b)
        {
            Fighter[] arr=new Fighter[2];
            int rand = rnd.Next(1, 3);
            if (rand == 1)
            {
                arr[0] = a;
                arr[1] = b;
            }
            else
            {
                arr[1] = a;
                arr[0] = b;
            }
            return arr;
        }
    }
}
