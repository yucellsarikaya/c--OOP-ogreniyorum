using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Worker : IWorker, IWorkerEat, IWorkerSalary
    {
        public void Eat()
        {
            Console.WriteLine("İşçi yemek yer");
        }

        public void GetSalary()
        {
            Console.WriteLine("İşçi maaş alır");
        }

        public void Work()
        {
            Console.WriteLine("İşçi çalışır");
        }
    }
}
