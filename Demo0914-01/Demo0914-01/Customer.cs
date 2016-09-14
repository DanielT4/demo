﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0914_01
{
    public class Customer
    {
        public string Name { get; set; }
        public string Secret { get; set; }

        //Vi gör egen kod för tostring
        //dvs ersätter default-beteendet

        public override string ToString()
        {
            return string.Format("Namn: {0}. [{1}]", Name, Secret);
        }
    }
}
