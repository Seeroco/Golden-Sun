using Golden_Sun_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Services
{
    public class SkillServices
    {
        public List<Skill> GetSkills()
        {
            DBConnector db = new DBConnector();
            SqlDataReader reader = db.connect("SELECT * FROM skills");
            while(reader.Read())
            {
                string s = reader["name"].ToString();
            }
            return new List<Skill>();
        }
    }
}