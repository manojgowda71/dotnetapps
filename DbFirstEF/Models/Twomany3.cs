using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class Twomany3
    {
        public Twomany3()
        {
            Manys = new HashSet<Twomany2>();
        }

        public int Id { get; set; }

        public virtual ICollection<Twomany2> Manys { get; set; }
    }
}
