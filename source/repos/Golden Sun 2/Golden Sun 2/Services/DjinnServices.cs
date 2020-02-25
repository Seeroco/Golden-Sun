using Golden_Sun_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Services
{
    public class DjinnServices
    {
        public List<Djinn> GetDjinns(string[] djinnNames)
        {
            DBConnector db = new DBConnector();
            var djinnReader = db.connect("SELECT * FROM djinns");
            List<Djinn> allDjinns = new List<Djinn>();
            while (djinnReader.Read())
            {
                allDjinns.Add(
                              new Djinn(djinnReader["name"].ToString(), djinnReader["element"].ToString()));
            }
            List<Djinn> djinns = new List<Djinn>();
            for(int i = 0; i<djinnNames.Length; i++)
            {
                djinns.Add(allDjinns.Find(djinn => djinn.Name.Equals(djinnNames[i])));
            }
            
            return djinns;
        }
    }
}