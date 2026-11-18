using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
    internal interface IDataBase
    {
         void Connect();
         void Disconnect();
         void Create(string data);
         void Read(int id);
         void Update(int id, string newData);
         void Delete(int id);
    }
}
