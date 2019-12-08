using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class Admins
    {
        SqlConnection conn;
        public Admins()
        {
            conn = new SqlConnection("Server=DESKTOP-4SCOPPB;Database=OAPA1;User Id=sa;Password=12345;");
        }

        public Admin AuthenticateAdmin(string name, string password)
        {
            Admin admin = null;
            conn.Open();
            string query = "SELECT * FROM Admins WHERE Name='" + name + "' and Password='" + password + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                admin = new Admin();
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Id = reader.GetString(reader.GetOrdinal("Id"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return admin;

        }

    }
}
