using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MySqlDatabase : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Added in MySql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted in MySql");
        }

        public void Update()
        {
            Console.WriteLine("Updated in MySql");
        }
    }
}
