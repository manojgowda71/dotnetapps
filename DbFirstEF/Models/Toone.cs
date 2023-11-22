using System;
using System.Collections.Generic;

namespace DbFirstEF.Models
{
    public partial class Toone
    {
        public int Id { get; set; }
        public int Relatedtooneid { get; set; }

        public virtual One Relatedtoone { get; set; } = null!;
    }
}
