using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class OrderStatus
    {
        public int StatusId { get; set; }
        public int OrderId { get; set; }
        public int OrderStatusSt { get; set; }
        public int Payment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Author { get; set; }


    }
}