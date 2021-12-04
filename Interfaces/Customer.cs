using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    public class Customer : IPerson
    {
        public int id { get; set; }
        public string name { get; set; }

        public String surname { get; set; }

        public Customer(int id, String name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }
}
