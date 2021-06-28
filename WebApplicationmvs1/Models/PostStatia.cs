using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class PostStatia
    {
        public int PostStatiaId { get; set; }
        public int PostStatiaText { get; set; }
        public DateTime PostStatiaDateCreation { get; set; }
        public DateTime PostStatiaDateRedakt { get; set; }
        public int PostStatiaLookNumber { get; set; }
        public  string  PostAutorName { get; set; }

    }
}