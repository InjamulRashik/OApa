using Oapa_final_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Controllers
{
    class LoginController
    {
        static Database db = new Database();
        static public dynamic AuthenticateUser(string number, string pin)
        {
            //bool result = false;
            var obj = db.Users.AuthenticateUser(number, pin);
            //if (obj != null) result = true;
            return obj;
        }
    }
}
