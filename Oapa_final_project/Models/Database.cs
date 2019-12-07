﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oapa_final_project.Models
{
    class Database
    {
        public Users Users { get; set; }
        public Admins Admins { get; set; }
        public Maids Maids { get; set; }
        public Babys Babys { get; set; }

        public Database()
        {
            Users = new Users();
            Admins = new Admins();
            Maids = new Maids();
            Babys = new Babys();
        }
    }
}
