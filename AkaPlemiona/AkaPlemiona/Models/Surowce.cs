using System;
using System.Collections.Generic;

namespace SlavVVar.Models
{
    public partial class Surowce
    {
        public int Drewno { get; set; }
        public int Zelazo { get; set; }
        public int Glina { get; set; }
        public int Id { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
