using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("abstract classes ile tamamlanmış ve tamamlanmamış methodlar yapılır");
        }
        
        public abstract void Delete();
    }
}
