using System;
using System.Collections.Generic;

namespace SlavVVar.Models
{
    public partial class UserData
    {
        public int Plemie { get; set; }
        public int Punkty { get; set; }
        public int Id { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
