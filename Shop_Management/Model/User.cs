﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Approved { get; set; }
        public bool Role { get; set; }
    }
}
