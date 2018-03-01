using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBD.Utility
{
    class General
    {

        public static string GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy dd.MM. HH:mm");
        }

    }
}
