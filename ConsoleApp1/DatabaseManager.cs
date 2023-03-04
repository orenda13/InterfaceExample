using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class DatabaseManager
    {
        public void Add(List<ICostumerDal> costumerDal)
        {
            foreach (ICostumerDal item in costumerDal)
            {
                item.Add();
            }
        }
        public void Delete(List<ICostumerDal> costumerDal)
        {
            foreach (ICostumerDal item in costumerDal)
            {
                item.Delete();
            }
        }
        public void Update(List<ICostumerDal> costumerDal)
        {
            foreach (ICostumerDal item in costumerDal)
            {
                item.Update();
            }
        }
    }
}
