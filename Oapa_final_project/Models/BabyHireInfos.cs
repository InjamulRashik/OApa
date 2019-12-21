using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class BabyHireInfos
    {
        SqlConnection conn;
        public BabyHireInfos()
        {
            conn = new SqlConnection("Server=DESKTOP-4SCOPPB;Database=OAPA1;User Id=sa;Password=12345;");
        }
        public bool AddInfo(BabyHireInfo babyHireInfo)
        {
            //add info into database

            conn.Open();

            string query = "INSERT INTO BabyHireInfo (UserName,BabyName) VALUES('" + babyHireInfo.Name + "','" + babyHireInfo.BabyName + "')";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, conn);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            if (result != 0) return true;
            else return false;

        }

            public ArrayList GetAllBabyHistory(string name)
            {
                ArrayList babyHireinfos = new ArrayList();
                conn.Open();
                string query = "SELECT * FROM BabyHireInfo WHERE UserName='" + name + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BabyHireInfo temp = new BabyHireInfo();
                    temp.Serial = reader.GetInt32(reader.GetOrdinal("Serial"));
                    temp.Name = reader.GetString(reader.GetOrdinal("UserName"));
                    temp.BabyName = reader.GetString(reader.GetOrdinal("BabyName"));
                    babyHireinfos.Add(temp);
                }
                conn.Close();
                return babyHireinfos;
            }

        public ArrayList GetAllBabyHistory1()
        {
            ArrayList babyHireinfos = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM BabyHireInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                BabyHireInfo temp = new BabyHireInfo();
                temp.Serial = reader.GetInt32(reader.GetOrdinal("Serial"));
                temp.Name = reader.GetString(reader.GetOrdinal("UserName"));
                temp.BabyName = reader.GetString(reader.GetOrdinal("BabyName"));
                babyHireinfos.Add(temp);
            }
            conn.Close();
            return babyHireinfos;
        }
    }
    } 

