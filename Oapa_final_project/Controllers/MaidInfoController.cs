using Oapa_final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Oapa_final_project.Controllers
{
    class MaidInfoController
    {
        static Database db = new Database();

        public static bool AddInfo(string name,string maidname)
        {
            //object sel = comboBoxProf.SelectedValue
            MaidHireInfo mhi = new MaidHireInfo();
            mhi.Name = name;
            mhi.MaidName = maidname;
           


            return db.Mihs.AddInfo(mhi);
        }
        public static ArrayList GetAllMaidHistory(string name)
        {
            return db.Mihs.GetAllMaidHistory(name);
        }

        public static ArrayList GetAllMaidHistory1()
        {
            return db.Mihs.GetAllMaidHistory1();
        }
    }
}
