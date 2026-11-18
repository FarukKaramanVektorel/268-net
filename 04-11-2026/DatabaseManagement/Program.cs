namespace DatabaseManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oracle oracle = new Oracle("10.15.23.45", "admin", "1234");
            MsSql mssql = new MsSql("10.15.24.45", "admin", "1234");
            FileSys fs = new FileSys("D:\\Logs");
            object obj = new object();
            obj.ToString();
            
            DataBaseManager.Management(fs);
        }
    }
}
