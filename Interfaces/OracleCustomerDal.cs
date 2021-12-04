using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("OracleCustomerDal eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("OracleCustomerDal silinedi");
        }

        public void Update()
        {
            Console.WriteLine("OracleCustomerDal güncellendi");
        }
    }
}

