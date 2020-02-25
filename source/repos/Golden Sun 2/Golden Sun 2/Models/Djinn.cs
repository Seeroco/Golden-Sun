using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Models
{
    public class Djinn
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public Skill Activation { get; set; }
        public Skill Invocation { get; set; }
        public Djinn(string name, string element)
        {
            this.Name = name;
            this.Element = element;
        }
    }
}