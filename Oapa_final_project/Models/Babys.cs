using System;
using System.Collections;
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
            conn = new SqlConnection("Server=DESKTOP-4SCOPPB;Database=OAPA1;User Id=sa;Password=12345;");
        }

        public Baby GetBaby(int id)
        {
            Baby baby = null;
            conn.Open();
            string query = "SELECT * FROM Babys WHERE BabyId='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                baby = new Baby();
                baby.BabyId = reader.GetString(reader.GetOrdinal("BabyId"));
                baby.BabyName = reader.GetString(reader.GetOrdinal("BabyName"));
                baby.BabyRate = reader.GetString(reader.GetOrdinal("BabyRate"));
            }
            conn.Close();
            return baby;
        }

        public ArrayList GetAllBabys()
        {
            ArrayList baby = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Babys";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Baby temp = new Baby();
                temp.BabyId = reader.GetString(reader.GetOrdinal("BabyId"));
                temp.BabyName = reader.GetString(reader.GetOrdinal("BabyName"));
                temp.BabyRate = reader.GetString(reader.GetOrdinal("BabyRate"));
                //temp.MaidId = reader.GetString(reader.GetOrdinal("MaidId"));
                baby.Add(temp);
            }
            conn.Close();
            return baby;
        }
        /*public ArrayList GetAllBabys()
        {
            ArrayList baby = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Babys";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Baby temp = new Baby();
                temp.BabyId = reader.GetString(reader.GetOrdinal("BabyId"));
                temp.BabyName = reader.GetString(reader.GetOrdinal("BabyName"));
                temp.BabyRate = reader.GetString(reader.GetOrdinal("BabyRate"));
                //temp.BabyId = reader.GetInt32(reader.GetOrdinal("BabyId"));
                baby.Add(temp);
            }
            conn.Close();
            return baby;
        }*/

        public bool AddBaby(Baby baby)
        {
            //add maid into database

            conn.Open();
            string query = "INSERT INTO Babys (BabyId,BabyName,BabyRate) VALUES('" + baby.BabyId + "','" + baby.BabyName + "','" + baby.BabyRate + "')";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result != 0) return true;
            else return false;

        }
    }

    }
