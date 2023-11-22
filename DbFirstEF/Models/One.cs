using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class One
    {
        public One()
        {
            Toones = new HashSet<Toone>();
        }

        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int? Twomanyid { get; set; }

        public virtual Twomany? Twomany { get; set; }
        public virtual ICollection<Toone> Toones { get; set; }
    }
}
