using Oapa_final_project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Controllers
{
    class MaidController
    {
       static Database db = new Database();
        public static bool AddMaid(string mname, string mrate)
        {
            //object sel = comboBoxProf.SelectedValue;

            Maid m = new Maid();
            m.MaidName = mname;
            m.MaidRate = mrate;
            



            /*var result = db.Users.AddUser(u);
            if (result) return true;
            else return false;*/
            return db.Maids.AddMaid(m);
        }

        public static ArrayList GetAllMaids()
        {
            return db.Maids.GetAllMaids();
        }

        public static Maid GetMaid(int id)
        {
            return db.Maids.GetMaid(id);
        }
    }
}
