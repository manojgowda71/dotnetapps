using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class Twomany2
    {
        public Twomany2()
        {
            Tomany2s = new HashSet<Twomany3>();
        }

        public int Id { get; set; }

        public virtual ICollection<Twomany3> Tomany2s { get; set; }
    }
}
