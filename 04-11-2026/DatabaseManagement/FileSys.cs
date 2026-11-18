using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
    internal class FileSys:IDataBase
    {
       

        public bool IsConnect { get; set; }
        public string Path { get; set; }
        public FileSys(string path)
        {
            Path= path;
        }

        public  void Connect()
        {
            if (!IsConnect)
            {
                Console.WriteLine($"{Path} yoluna bağlanıldı");
                IsConnect = true;
            }
            else
            {
                Console.WriteLine("Bağlantı zaten açık...");
            }
        }

        public  void Create(string data)
        {
            Console.WriteLine($"{data} FileSystem databasede kaydediliyor...");
        }

        public  void Delete(int id)
        {
            Console.WriteLine($"{id} ci kayıt FileSystem databaseden siliniyor...");
        }

        public  void Disconnect()
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

        public  void Read(int id)
        {
            Console.WriteLine($"{id} ci kayıt FileSystem databaseden okunuyor...");
        }

        public  void Update(int id, string newData)
        {
            Console.WriteLine($"{id} ci kayıt, FileSystem databasede {newData} ile değiştirildi");
        }
    }
}
