using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Db.DAL.ORM.Entities.Concrete
{
    public class Product : BaseEntity
    {
        [Required]
        [MinLength(3, ErrorMessage = "Min. Length is 3")]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        public decimal UnitInStock { get; set; }
        public short UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
