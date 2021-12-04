using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class DbMysql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Virtual sayesinde miras alıdığı methodu ezdi");
        }
    }
}
