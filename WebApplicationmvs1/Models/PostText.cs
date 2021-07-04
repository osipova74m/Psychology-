using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class PostText
    {
        public Guid  Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int LookNumber { get; set; }
        public string Body { get; set; }

        public Guid UserId { get; set; }
        public User  User { get; set; }
    }
}