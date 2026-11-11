using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    internal abstract class Account
    {
        public const string BANK_NAME = "BANK ANGARA";

        public Customer Customer { get; set; }       

        public string IBAN { get; private set; }
        private readonly Random rnd = new Random();

        private string _subeKodu;

        public string SubeKodu
        {
            get { return _subeKodu; }
            set
            {
               
                if (value.Length == 4)
                {
                    _subeKodu = value;
                }
                else
                {
                    _subeKodu = "0000";
                }
            }
        }
        public Account(Customer customer, string subeKodu)
        {
            Customer = customer;
            SubeKodu = subeKodu;
            IBAN = CreateIBAN(SubeKodu);
        }

        private string CreateIBAN(string subeKodu)
        {
            string iban = "TR" + subeKodu;
            string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for (int i = 0; i < 10; i++)
            {
                iban += numbers[rnd.Next(10)];
            }
            return iban;

        }

        public abstract void ParaCek(decimal tutar);

        public abstract void ParaYatir(decimal tutar);

    }
}
