using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class Twomany
    {
        public Twomany()
        {
            Ones = new HashSet<One>();
        }

        public int Id { get; set; }

        public virtual ICollection<One> Ones { get; set; }
    }
}
