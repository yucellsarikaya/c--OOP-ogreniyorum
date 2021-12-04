using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Class1 : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Miraz aldığı sınıf da delete methodu tamamlanmadığı içn burada zorunlu olarak method alınır ve kendisi tamamlar");
        }
    }
}
