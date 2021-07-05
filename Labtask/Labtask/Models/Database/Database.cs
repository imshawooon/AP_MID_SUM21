using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Labtask.Models.Database
{
    public class Database
    {
        public Students Student { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-PH1NG8J;Database=CrudO;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Student = new Students(conn);

        }
    }
}