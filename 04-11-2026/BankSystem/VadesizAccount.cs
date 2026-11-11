using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    internal class VadesizAccount:Account
    {
        public decimal Balance { get; set; }
        public VadesizAccount(decimal balance,Customer customer, string subeKodu) : base(customer, subeKodu)
        {
            Balance = balance;
            customer.AddAccount(this);
        }

        public override void ParaCek(decimal tutar)
        {
            if (Balance - tutar > 0)
            {
                Balance -= tutar;
                Console.WriteLine($"{tutar:c2} mitarında para çekme işlemi yapıldı.\nKalan Bakiye: {Balance:c2}");
            }
            else
            {
                Console.WriteLine("Yetersiz Bakiye...");
            }
        }

        public override void ParaYatir(decimal tutar)
        {
            Balance+= tutar;
            Console.WriteLine($"{tutar:c2} mitarında para yatırma işlemi yapıldı.\nMevcut Bakiye: {Balance:c2}");
        }
        public override string ToString()
        {
            return $"Vadesiz Hesap: {BANK_NAME} - {IBAN} - {Balance:c2} ";
        }
    }
}
