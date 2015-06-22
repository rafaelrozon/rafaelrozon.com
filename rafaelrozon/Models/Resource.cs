﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rafaelrozon.Models
{
    public class Resource
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public int Status { get; set; }

        public String Description { get; set; }

        public String Link { get; set; }

        public ICollection<Categories> Categories { get; set; }
    }
}
