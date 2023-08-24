using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public enum Status
    {
        Pending,
        Approved,
        Declined,
        Shipped,
        Delivered
    }
    public class Order : BaseEntity
    {
        public int TotalPrice { get; set; }
        public Customer Customer { get; set; }

    }
}
