using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrderDetails
    {
        public int OrderedCount { get; set; }
        public int UnitPrice { get; set; }
        public Guid OrderId;
        public Order Order { get; set; }
        public Guid ProductId;
        public Product Product { get; set; }


    }
}
