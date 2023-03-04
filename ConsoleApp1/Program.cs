using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            SqlDatabase sqlDatabase =new SqlDatabase();
            OracleDatabase oracleDatabase = new OracleDatabase();
            MySqlDatabase mySqlDatabase = new MySqlDatabase();  
            List<ICostumerDal>costumerDals=new List<ICostumerDal>() {sqlDatabase ,oracleDatabase,mySqlDatabase};
            databaseManager.Add(costumerDals);
            databaseManager.Delete(costumerDals);
            databaseManager.Update(costumerDals);
        }
    }
    
}
