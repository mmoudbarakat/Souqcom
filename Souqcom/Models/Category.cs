﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Souqcom.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string ClassFilter { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
