using Oapa_final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Controllers
{
    class AdminLoginController
    {
        static Database db = new Database();
        static public dynamic AuthenticateAdmin(string name, string password)
        {
            //bool result = false;
            var obj = db.Admins.AuthenticateAdmin(name, password);
            //if (obj != null) result = true;
            return obj;
        }
    }
}
