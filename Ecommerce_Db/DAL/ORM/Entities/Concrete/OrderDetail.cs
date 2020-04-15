using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_Db.DAL.ORM.Entities.Concrete
{
    public class OrderDetail : BaseEntity
    {
        public short UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public float Discount { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
