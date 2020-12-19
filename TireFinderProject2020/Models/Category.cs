﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public String CategoryName { get; set; }

        public String CategoryDescription { get; set; }

        public List<Tire> Tires { get; set; }

    

    }
}
