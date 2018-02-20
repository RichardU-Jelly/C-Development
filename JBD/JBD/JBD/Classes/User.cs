using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBD;

namespace JBD.Classes
{
    class User
    {

        private string ID;
        private string Name;

        public User() {
            ID = null;
            Name = null;
        }

        public User(string name) {
            ID = Utility.MD5.CreateMD5(name);
            Name = name;
        }

    }
}
