using System;
using System.Collections.Generic;

namespace SlavVVar.Models
{
    public partial class PoziomyBudynkow
    {
        public int Budynek1 { get; set; }
        public int Budynek2 { get; set; }
        public int Budynek3 { get; set; }
        public int Budynek4 { get; set; }
        public int Budynek5 { get; set; }
        public int Budynek6 { get; set; }
        public int Budynek7 { get; set; }
        public int Budynek8 { get; set; }
        public int Budynek9 { get; set; }
        public int Budynek0 { get; set; }
        public int Id { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
