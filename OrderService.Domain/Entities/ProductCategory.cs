using OrderService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Domain.Entities
{
    public class ProductCategory : IdentifiableEntity
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }

        public ICollection<Product> Products { get; private set; }
    }
}
