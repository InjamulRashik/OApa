﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class Maids
    {

        SqlConnection conn;
        public Maids()
        {
            conn = new SqlConnection("Server=DESKTOP-M4LHFUP;Database=OAPA;User Id=sa;Password=12345;");
        }

        public Maid GetMaid(int id)
        {
            Maid maid = null;
            conn.Open();
            string query = "SELECT * FROM Maids WHERE MaidId='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                maid = new Maid();
                maid.MaidId = reader.GetInt32(reader.GetOrdinal("MaidId"));
                maid.MaidName = reader.GetString(reader.GetOrdinal("MaidName"));
                maid.MaidRate = reader.GetString(reader.GetOrdinal("MaidRate"));
            }
            conn.Close();
            return maid;
        }

    }
}
