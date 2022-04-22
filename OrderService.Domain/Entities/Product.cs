using OrderService.Domain.Common;
using System.Collections.Generic;

namespace OrderService.Domain.Entities
{
    public class Product : IdentifiableEntity
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsInOrder { get; set; }
        public byte[] Image { get; set; }
        public bool Active { get; set; }

        public ProductCategory Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; private set; }
    }
}
