using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oapa_final_project.Models;
using Oapa_final_project.Controllers;
using System.Data.SqlClient;
using System.Collections;

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

        public ArrayList GetAllUsers()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User u = new User()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Number = reader.GetString(reader.GetOrdinal("Number")),
                    Pin = reader.GetString(reader.GetOrdinal("Pin")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Profession = reader.GetString(reader.GetOrdinal("Profession")),
                };
                
            }
            conn.Close();
            return users;
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
