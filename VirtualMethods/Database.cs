using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("varsaylıan method kullanıldı");
        }

        public virtual void Delete()
        {
            Console.WriteLine("db den veri silindi ");
        }
    }
}
