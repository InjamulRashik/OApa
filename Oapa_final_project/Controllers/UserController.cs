using Oapa_final_project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Controllers
{
    class UserController
    {
        static Database db = new Database();
        
        public static bool AddUser(string name, string number, string pin,string gender, string profession)
        {
            //object sel = comboBoxProf.SelectedValue
            User u = new User();
            u.Name = name;
            u.Number = number;
            u.Pin = pin;
            u.Gender = gender;
            u.Profession = profession;



            /*var result = db.Users.AddUser(u);
            if (result) return true;
            else return false;*/
            return db.Users.AddUser(u);
        }

        public static ArrayList GetAllUsers()
        {
            return db.Users.GetAllUsers();
        }


    }
}
