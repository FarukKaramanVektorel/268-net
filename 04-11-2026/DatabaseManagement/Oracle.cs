using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
    internal class Oracle : DataBase
    {
        public Oracle(string path, string username, string password) : base(path, username, password)
        {
        }

        public override void Connect()
        {
            if (!IsConnect)
            {
                Console.WriteLine($"{Path} yoluna, {Username} kullanıcısı ve {Password} şifresi ile bağlanıldı");
                IsConnect = true;
            }
            else
            {
                Console.WriteLine("Bağlantı zaten açık...");
            }
        }

        public override void Create(string data)
        {
            Console.WriteLine($"{data} oracle databasede kaydediliyor...");
        }

        public override void Delete(int id)
        {
            Console.WriteLine($"{id} ci kayıt oracle databaseden siliniyor...");
        }

        public override void Disconnect()
        {
            if (IsConnect)
            {
                Console.WriteLine("Bağlantı koparıldı");
                IsConnect = false;
            }
            else
            {
                Console.WriteLine("Bağlantı zaten kapalı...");
            }
        }

        public override void Read(int id)
        {
            Console.WriteLine($"{id} ci kayıt oracle databaseden okunuyor...");
        }

        public override void Update(int id, string newData)
        {
            Console.WriteLine($"{id} ci kayıt, oracle databasede {newData} ile değiştirildi");
        }
    }
}
