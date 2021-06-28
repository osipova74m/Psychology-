using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class Consult
    {
        public int ConsultId { get; set; }
        public string UserEmail { get; set; }
        public string ConsultTheme { get; set; }
        public string Order { get; set; }
        public string ConsultMessage { get; set; }
        public DateTime ConsultDate { get; set; }

    }
}