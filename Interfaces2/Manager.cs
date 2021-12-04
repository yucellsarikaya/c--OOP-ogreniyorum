using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Manager : IWorkerEat, IWorkerSalary
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici yemek yer");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yönetici maaş alır");
        }
    }
}
