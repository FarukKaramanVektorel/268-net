using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BankSystem
{
    internal class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcKimlikNo { get; set; }
        public string Password { get; set; }

        public VadeliAccount[] AccountsF = new VadeliAccount[0];
        public VadesizAccount[] Accounts = new VadesizAccount[0];
        public Customer(string firstName, string lastName, string tcKimlikNo, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            TcKimlikNo = tcKimlikNo;
            Password = password;


        }

        public void AddAccount(VadesizAccount account)
        {
            Array.Resize(ref Accounts, Accounts.Length + 1);
            Accounts[Accounts.Length - 1] = account;
        }

        public void AddAccountF(VadeliAccount account)
        {
            Array.Resize(ref AccountsF, AccountsF.Length + 1);
            AccountsF[AccountsF.Length - 1] = account;
        }
        //public void RemoveAccount(Account account)
        //{
        //    int index = Array.IndexOf(Accounts, account);
        //    Account[] newArr = new Account[Accounts.Length - 1];
        //    int indis = 0;
        //    for (int i = 0; i < Accounts.Length; i++)
        //    {
        //        if (i != index)
        //        {
        //            newArr[indis++] = Accounts[i];
        //        }
        //    }
        //    Accounts = newArr;
        //}

       

        public override string ToString()
        {
            string acoounts = "Vadesiz Hesaplar:\n";
            for (int i = 0; i < Accounts.Length; i++)
            {
                acoounts +=i+1+". Hesap "+ Accounts[i] + "\n";
            }
            acoounts += "Vadeli Hesaplar:\n";
            for (int i = 0; i < AccountsF.Length; i++)
            {
                acoounts += i + 1 + ". Hesap " + AccountsF[i] + "\n";
            }
            return $"Müşteri: {FirstName} {LastName} Hesaplar:\n{acoounts}";
        }
    }
}
