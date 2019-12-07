using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class Babys
    {

        SqlConnection conn;
        public Babys()
        {
            conn = new SqlConnection("Server=DESKTOP-M4LHFUP;Database=OAPA;User Id=sa;Password=12345;");
        }

        public Baby GetBaby(int id)
        {
            Baby baby = null;
            conn.Open();
            string query = "SELECT * FROM Maids WHERE BabyId='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                baby = new Baby();
                baby.BabyId = reader.GetInt32(reader.GetOrdinal("BabyId"));
                baby.BabyName = reader.GetString(reader.GetOrdinal("BabyName"));
                baby.BabyRate = reader.GetString(reader.GetOrdinal("BabyRate"));
            }
            conn.Close();
            return baby;
        }
    }
}
