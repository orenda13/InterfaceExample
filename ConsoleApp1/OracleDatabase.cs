using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OracleDatabase : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Added in Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted in Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Updated in Oracle");
        }
    }
}
