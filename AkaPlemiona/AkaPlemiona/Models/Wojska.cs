using System;
using System.Collections.Generic;

namespace SlavVVar.Models
{
    public partial class Wojska
    {
        public int Wojsko1 { get; set; }
        public int Wojsko2 { get; set; }
        public int Wojsko3 { get; set; }
        public bool Specjalny { get; set; }
        public int Id { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
