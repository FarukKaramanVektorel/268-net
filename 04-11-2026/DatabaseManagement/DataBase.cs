using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
    internal abstract class DataBase:AraBase, IDataBase
    {
        public string Path { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsConnect { get; set; }
        public DataBase(string path, string username, string password)
        {
            Path = path;
            Username = username;
            Password = password;
        }

        public abstract void Connect();
        public abstract void Disconnect();
        public abstract void Create(string data);
        public abstract void Read(int id);
        public abstract void Update(int id, string newData);
        public abstract void Delete(int id);
    }
}
