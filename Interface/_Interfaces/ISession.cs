using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using Interface.webapi;

namespace Interface._Interfaces
{
    interface ISession
    {
        void login(string login, string password);//tworzy uchwyt sesji
    }
}
