using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    internal class VadeliAccount : Account
    {


        public decimal Balance { get; set; }
        public decimal Amount { get; set; }
        public double Oran { get; set; }
        public int Vade { get; set; }

        public VadeliAccount(decimal balance, Customer customer,
            string subeKodu, double oran = 40, int vade = 99) : base(customer, subeKodu)
        {

            Balance = balance;           
            Oran = oran;
            Vade = vade;
            Amount = VadeSonuHesapla(false, vade);
            customer.AddAccountF(this);
        }

        private decimal VadeSonuHesapla(bool isAddBakiye, double gunKalan)
        {
            double t =  gunKalan / 365.0;
            Amount = Balance * (decimal)Math.Pow((1 + Oran/100), t);
            if (isAddBakiye)
            {
                decimal harac= decimal.Multiply(Amount, (decimal)0.05);
                Amount -= harac;
                Console.WriteLine($"Vadeyi Bozduğunuz için" +
                    $" {harac:c2} miktarında parayı tırtıkladık ");
            }
            return Amount;
        }

        public override void ParaCek(decimal tutar)
        {
            if (Input.boolAl("Vade bozulacak eminmisiniz?"))
            {
                Console.WriteLine("Paranızın getirisini alamayacaksınız...");
                Balance -= tutar;
                Amount = VadeSonuHesapla(true, Input.sayiAl("Kalan gün sayısını giriniz"));
            }
        }

        public override void ParaYatir(decimal tutar)
        {

            Balance += tutar;
            Amount = VadeSonuHesapla(false, Input.sayiAl("Kalan gün sayısını giriniz"));
        }

        public override string ToString()
        {
            return $"Vadeli Hesap: {BANK_NAME} - {IBAN} Ana Para: {Balance:c2} vade {Vade} oran {Oran} Vade Sonu Bakiye: {Amount:c2} ";
        }
    }
}
