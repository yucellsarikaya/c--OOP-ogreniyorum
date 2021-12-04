using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MysqlCustomerDal eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MysqlCustomerDal silinedi");
        }

        public void Update()
        {
            Console.WriteLine("MysqlCustomerDal güncellendi");
        }
    }
}
