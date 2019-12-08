using Oapa_final_project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Controllers
{
    class BabyController
    {

        static Database db = new Database();
        public static bool AddBaby(string bname, string brate)
        {
            //object sel = comboBoxProf.SelectedValue;

            Baby b = new Baby();
            b.BabyName = bname;
            b.BabyRate = brate;




            /*var result = db.Users.AddUser(u);
            if (result) return true;
            else return false;*/
            return db.Babys.AddBaby(b);
        }

        public static ArrayList GetAllBabys()
        {
            return db.Babys.GetAllBabys();
        }
        public static Baby GetBaby(int id)
        {
            return db.Babys.GetBaby(id);
        }
    }
}
