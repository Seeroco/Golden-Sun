using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int PPCost { get; set; }
        public string Element { get; set; }
    }
}