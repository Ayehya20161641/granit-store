﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace granitonlinestore.Models
{
    public class ProductTypes
{
        public int id { get; set;}
        [Required]

        public string name { get; set;}

}
}
