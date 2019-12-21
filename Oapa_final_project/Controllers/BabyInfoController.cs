using Oapa_final_project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Controllers
{
    class BabyInfoController
    {
        static Database db = new Database();

        public static bool AddInfo(string name, string babyname)
        {
            //object sel = comboBoxProf.SelectedValue
            BabyHireInfo bhi = new BabyHireInfo();
            bhi.Name = name;
            bhi.BabyName = babyname;



            return db.Bihs.AddInfo(bhi);
        }

        public static ArrayList GetAllBabyHistory(string name)
        {
            return db.Bihs.GetAllBabyHistory(name);
        }

        public static ArrayList GetAllBabyHistory1()
        {
            return db.Bihs.GetAllBabyHistory1();
        }
    }

}
