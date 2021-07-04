using System;

namespace WebApplicationmvs1.Models
{
    public class Consult
    {
        public Guid Id { get; set; }
        public string EmailFrom { get; set; }
        public string Theme { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }

    }
}