﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North_DbFirst.Models
{
    public partial class Employee
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
