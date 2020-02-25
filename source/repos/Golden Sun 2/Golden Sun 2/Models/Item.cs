using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Models
{
   
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stat { get; set; }
        public int Cost { get; set; }
        public bool Rare { get; set; }
        public Item(int id, string name, int stat, int cost, bool rare)
        {
            this.ID = id;
            this.Name = name;
            this.Stat = stat;
            this.Cost = cost;
            this.Rare = rare;
        }
    }
}