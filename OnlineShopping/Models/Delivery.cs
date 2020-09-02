using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Delivery
    {
        public int Id { get; set; }

        public bool Status { get; set; }

        public int OrderId{get; set; }

        public Order Order { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string DeliveryAddress { get; set; }
    }
}
