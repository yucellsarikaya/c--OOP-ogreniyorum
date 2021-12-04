using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MsSqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MsSqlCustomerDal eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MsSqlCustomerDal silinedi");
        }

        public void Update()
        {
            Console.WriteLine("MsSqlCustomerDal güncellendi");
        }
    }
}
