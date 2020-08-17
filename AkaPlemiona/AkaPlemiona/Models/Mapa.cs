using System;
using System.Collections.Generic;

namespace SlavVVar.Models
{
    public partial class Mapa
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Data { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
