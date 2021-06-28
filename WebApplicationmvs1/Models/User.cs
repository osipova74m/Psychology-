using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int UserName { get; set; }
        public int UserSecondName { get; set; }
        public DateTime UserDate { get; set; }
        public int UserPhone { get; set; }
        public string UserEmail { get; set; }
    }
}