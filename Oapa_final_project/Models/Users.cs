using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class Users
    {

        SqlConnection conn;
        public Users()
        {
            conn = new SqlConnection("Server=DESKTOP-M4LHFUP;Database=OAPA;User Id=sa;Password=12345;");
        }

        public User AuthenticateUser(string number, string pin)
        {
            User user = null;
            conn.Open();
            string query = "SELECT * FROM Users WHERE Number='" + number + "' and Pin='" + pin + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Number = reader.GetString(reader.GetOrdinal("Number"));
                user.Pin = reader.GetString(reader.GetOrdinal("Pin"));
            }
            conn.Close();
            return user;
        }
        public User GetUser(string name)
        {
            User user = null;
            conn.Open();
            string query = "SELECT * FROM Users WHERE Name='" + name + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = new User();
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Number = reader.GetString(reader.GetOrdinal("Number"));
                user.Pin = reader.GetString(reader.GetOrdinal("Pin"));
            }
            conn.Close();
            return user;
        }

        public bool AddUser(User user)
        {
            //add user into database

            conn.Open();
            string query = "INSERT INTO Users (Name,Number,Pin,Gender,Profession) VALUES('" + user.Name + "','" + user.Number + "','" + user.Pin + "','" + user.Gender + "','" + user.Profession + "')";
            Console.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result != 0) return true;
            else return false;
        }
    }

}
