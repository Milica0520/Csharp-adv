﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class6.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }
        public override string GetInfo()
        {
            return $"{Id} - {Title} {Description}";
        }
    }
}
