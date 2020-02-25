using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Golden_Sun_2.Models;

namespace Golden_Sun_2.Services
{
    public class CharacterServices
    {
        public List<Character> GetParty()
        {
            List<Character> party = new List<Character>();
            Character hans = new Character("Hans","Venus");
            hans.Djinns.Add(new Djinn("Silex","Venus"));
            party.Add(hans);
            return party;
        }
        public List<Character> GetAllCharacters()
        {
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IER4R6O; Initial Catalog = GoldenSunDB; Integrated Security = True");
            SqlCommand oCmd = new SqlCommand("SELECT * FROM characters", connection);
            connection.Open();
            var reader = oCmd.ExecuteReader();
            var pjs = new List<Character>();
            while (reader.Read())
            {
                var pj = new Character(reader["name"].ToString(), reader["element"].ToString());
                var djinnName = reader["djinns"].ToString();
                var djinns = djinnName.Split(',');
                DjinnServices djs = new DjinnServices();
                pj.Djinns = djs.GetDjinns(djinns);
                pjs.Add(pj);
            }
            return pjs;
        }
        public Character GetCharacter(string matchingName)
        {
            var db = new DBConnector();
            var reader = db.connect("SELECT * FROM CHARACTERS");
            var pj = new Character("Default", "Default");
            while (reader.Read())
            {
                string vname = reader["name"].ToString();
                if (matchingName.ToLower().Equals(vname.ToLower()))
                {
                    break;                  
                }
                
            }
            pj = new Character(reader["name"].ToString(), reader["element"].ToString());
            string djinnName = reader["djinns"].ToString();
            string[] djinns = djinnName.Split(',');
            string[] items = reader["items"].ToString().Split(',');
            List<int> itemID  = new List<int>();
            foreach (var item in items)
            {
                itemID.Add(int.Parse(item));
            }
            DjinnServices djinnS = new DjinnServices();
            pj.Djinns = djinnS.GetDjinns(djinns);
            ItemServices itemS = new ItemServices();
            pj.Inventory = itemS.GetItems(itemID);
            return pj;
        }
    }
}