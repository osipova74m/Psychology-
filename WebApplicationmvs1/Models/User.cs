using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationmvs1.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Registred { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Consult> Consultations { get; set; }
    }
}