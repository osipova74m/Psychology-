using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class OrderServis
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerEmail { get; set; }
        public string Theme { get; set; }
        public string Subject { get; set; }
        public int OrderTerm { get; set; }

    }
}