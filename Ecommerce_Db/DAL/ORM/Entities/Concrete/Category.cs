﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Db.DAL.ORM.Entities.Concrete
{
    public class Category : BaseEntity
    {
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string CategoryDescription { get; set; }
        public string ImageURL { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
