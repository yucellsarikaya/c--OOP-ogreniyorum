﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class CustomerManager
    {
        public void Add(ICustomerDal dal)
        {
            dal.Add();
        }
    }
}
