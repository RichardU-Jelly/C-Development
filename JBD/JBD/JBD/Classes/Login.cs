using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JBD.Classes
{
    class Login
    {

        private User _user;
        private string _password;
        private string _timeStamp = Utility.General.GetTimestamp(DateTime.Now);
        private string _email;

        public Login(User user, string pwd, string timestamp, string email)
        {
            //TODO
        }

    }
}
