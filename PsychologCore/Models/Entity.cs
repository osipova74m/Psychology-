using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsychologCore.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public bool IsHidden { get; set; }
    }
}
