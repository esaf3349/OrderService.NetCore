using OrderService.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Domain.Entities
{
    public class Order : IdentifiableEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderTime { get; set; }
        public DateTime? RequiredTime { get; set; }
        public DateTime? ShippedTime { get; set; }
        public string ShipCountry { get; set; }
        public string ShipRegion { get; set; }
        public string ShipCity { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPostalCode { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; private set; }
    }
}
