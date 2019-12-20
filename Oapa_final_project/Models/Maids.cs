using System;
using System.Collections;
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
            conn = new SqlConnection("Server=DESKTOP-4SCOPPB;Database=OAPA1;User Id=sa;Password=12345;");
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
                maid.MaidId = reader.GetString(reader.GetOrdinal("MaidId"));
                maid.MaidName = reader.GetString(reader.GetOrdinal("MaidName"));
                maid.MaidRate = reader.GetString(reader.GetOrdinal("MaidRate"));
                //maid.Name = reader.GetString(reader.GetOrdinal("Name"));
            }
            conn.Close();
            return maid;
        }

        public ArrayList GetAllMaids()
        {
            ArrayList maid = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Maids";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Maid temp = new Maid();
                temp.MaidId = reader.GetString(reader.GetOrdinal("MaidId"));
                temp.MaidName = reader.GetString(reader.GetOrdinal("MaidName"));
                temp.MaidRate = reader.GetString(reader.GetOrdinal("MaidRate"));
                //temp.MaidId = reader.GetString(reader.GetOrdinal("MaidId"));
                maid.Add(temp);
            }
            conn.Close();
            return maid;
        }

        public bool AddMaid(Maid maid)
        {
            //add maid into database

            conn.Open();
            string query = "INSERT INTO Maids (MaidId,MaidName,MaidRate) VALUES('" + maid.MaidId + "','" + maid.MaidName + "','" + maid.MaidRate + "')";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result != 0) return true;
            else return false;
        }

    }
}
