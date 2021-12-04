using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot çalışır");
        }
    }
}
