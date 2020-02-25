using Golden_Sun_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Services
{
    public class ItemServices
    {
        public List<Item> GetItems(List<int> itemsID)
        {
            DBConnector db = new DBConnector();
            List<Item> allItems = new List<Item>();
            var itemReader = db.connect("SELECT * FROM longswords");
            while (itemReader.Read())
            {
                allItems.Add(new Item(int.Parse(itemReader["ID"].ToString()),
                                             itemReader["Name"].ToString(),
                                             int.Parse(itemReader["Stat"].ToString()),
                                             int.Parse(itemReader["Cost"].ToString()),
                                             itemReader["is_rare"].ToString().Equals("True")));

            }
            List<Item> items = new List<Item>();
            for (int i = 0; i < itemsID.Count; i++)
            {
                items.Add(allItems.Find(item => item.ID == itemsID[i]));
            }
            
            return items;
            //Hello Itemsss

        }
    }
}