using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class MaidHireInfos
    {
        SqlConnection conn;
        public MaidHireInfos()
        {
            conn = new SqlConnection("Server=DESKTOP-4SCOPPB;Database=OAPA1;User Id=sa;Password=12345;");
        }
        public bool AddInfo(MaidHireInfo maidHireInfo)
        {
            //add info into database

            conn.Open();

            string query = "INSERT INTO MaidHireInfo (UserName,MaidName) VALUES('" + maidHireInfo.Name + "','" + maidHireInfo.MaidName + "')";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, conn);

            int result = cmd.ExecuteNonQuery();

            conn.Close();
            if (result != 0) return true;
            else return false;
        }

        public ArrayList GetAllMaidHistory(string name)
        {
            ArrayList maidHireinfos = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM MaidHireInfo WHERE UserName='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MaidHireInfo temp = new MaidHireInfo();
                temp.Serial = reader.GetInt32(reader.GetOrdinal("Serial"));
                temp.Name = reader.GetString(reader.GetOrdinal("UserName"));
                temp.MaidName = reader.GetString(reader.GetOrdinal("MaidName"));
                maidHireinfos.Add(temp);
            }
            conn.Close();
            return maidHireinfos;
        }

        public ArrayList GetAllMaidHistory1()
        {
            ArrayList maidHireinfos = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM MaidHireInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MaidHireInfo temp = new MaidHireInfo();
                temp.Serial = reader.GetInt32(reader.GetOrdinal("Serial"));
                temp.Name = reader.GetString(reader.GetOrdinal("UserName"));
                temp.MaidName = reader.GetString(reader.GetOrdinal("MaidName"));
                maidHireinfos.Add(temp);
            }
            conn.Close();
            return maidHireinfos;
        }
    }
}
