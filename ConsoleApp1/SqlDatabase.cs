using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SqlDatabase : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Added in Sql");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted in Sql");
        }

        public void Update()
        {
            Console.WriteLine("Updated in Sql");
        }
    }
}
