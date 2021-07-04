using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class OrderStatus
    {
        public Guid Id { get; set; }
        public OrderServis OrderServis { get; set; }
        public string OrderStatusSt { get; set; }
        public Guid  Payment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Author { get; set; }

        public Guid OrderServisId { get; set; }
        
            
    }
}