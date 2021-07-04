using System;

namespace WebApplicationmvs1.Models
{
    public class OrderServis
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerEmail { get; set; }
        public string Theme { get; set; }
        public string Subject { get; set; }
        public Guid OrderTerm { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public Guid OrderStatusId { get; set; }


    }
}