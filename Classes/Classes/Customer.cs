using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {

        //public int id;  //field
        public int id { get; set; }

        private string _firstName;
        public String firstName { get { return ("Sayın " + _firstName); } set { _firstName = value + " Berkay"; } } //Property
        public String lastName { get; set; }
        public String city { get; set; }
    }
}
