using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOrderedUtc { get; set; }
        public Guid CustomerName { get; set; }
        public string OrderNumber => $"SO{OrderId:D6}";

        //relationshops
        public ICollection<LineItem> LineItems { get; set; }
    
        public Order()
        {
            DateOrderedUtc = DateTime.UtcNow;
        }
    }
}
