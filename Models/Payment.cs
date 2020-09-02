using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public bool Status { get; set; }
    }
}
