using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseManagement
{
    internal class DataBaseManager
    {
        public static void Management(IDataBase database)
        {            
                database.Connect();
                database.Connect();
                database.Create("Bişeyler...");
                database.Read(1);
                database.Update(1,"Yeni bişeyler");
                database.Delete(1);
                database.Disconnect();
        }

    }
}
