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

        public static ArrayList GetAllBabys()
        {
            return db.Babys.GetAllBabys();
        }

    }
}
