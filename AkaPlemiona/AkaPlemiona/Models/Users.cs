using System;
using System.Collections.Generic;

namespace SlavVVar.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public virtual PoziomyBudynkow PoziomyBudynkow { get; set; }
        public virtual Surowce Surowce { get; set; }
        public virtual UserData UserData { get; set; }
        public virtual Wojska Wojska { get; set; }
    }
}
