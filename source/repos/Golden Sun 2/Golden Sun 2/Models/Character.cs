using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public List<Item> Inventory { get; set; }

        public List<Djinn> Djinns { get; set; }
        public List<Skill> Psynergies { get; set; }
        public string Element { get; set; }
        public Character(string Name, string Element)
        {
            this.Name = Name;
            this.Hp = 10;
            this.Attack = 10;
            this.Defense = 10;
            this.Speed = 10;
            this.Djinns = new List<Djinn>();
            this.Psynergies = new List<Skill>();
            this.Element = Element;
            this.Inventory = new List<Item>();
        }
    }
}