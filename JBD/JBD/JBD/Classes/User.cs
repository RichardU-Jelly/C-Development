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

        private string _id;
        private string _name;

        public User(string name)
        {
            _id = Utility.MD5.CreateMD5(name);
            _name = name;
        }
        
        public string Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
