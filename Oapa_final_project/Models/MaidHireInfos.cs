using System;
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
    }
}
