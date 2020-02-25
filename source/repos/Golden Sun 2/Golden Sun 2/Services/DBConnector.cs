using Golden_Sun_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Golden_Sun_2.Services
{
    public class DBConnector
    {
        public SqlDataReader connect(string command)
        {
            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-IER4R6O; Initial Catalog = GoldenSunDB; Integrated Security = True");
            SqlCommand retrieve = new SqlCommand(command, connection);
            connection.Open();
            return  retrieve.ExecuteReader();   
        }
    }
}