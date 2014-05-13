using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface._Classes
{
    class Users
    {
        public string getUserName(long id,Session s)
        {
            return s.allegroService.doGetUserLogin(s.COUNTRYID,Convert.ToInt32(id), s.WEBAPIKEY);
        }
    }
}
