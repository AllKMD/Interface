using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interface._Interfaces;
using Interface.webapi;
using System.Security.Cryptography;

namespace Interface._Classes
{
    public class Session:ISession
    {
        public AllegroWebApiService allegroService;   

        private string webAPIKey;
        string sessionHandle="";
        private long userId, serverTime, localVersion;
        private int countryId;

        //METODY
        public Session(string webAPIKey,int countryId)
        {
            allegroService = new AllegroWebApiService();

            this.countryId = countryId;
            this.webAPIKey = webAPIKey;

            allegroService.doQuerySysStatus(3, countryId, webAPIKey, out localVersion);//pobieranie versionKey
        }
        public void login(string login,string password)
        { 
            
            ////szyfrowanie hasla
            SHA256 sha = new SHA256Managed();
            byte[] byteArrayPassword = Encoding.ASCII.GetBytes(password);//konwersja na tablice bajtow
            byte[] passwordHash = sha.ComputeHash(byteArrayPassword);//produkcja haszu
            string encodedPassword = Convert.ToBase64String(passwordHash);//konwersja na string

            ////logowanie
            try
            {
                sessionHandle = allegroService.doLoginEnc(
                    login,
                    encodedPassword,
                    countryId,
                    webAPIKey,
                    localVersion,
                    out userId,
                    out serverTime);
            }
            catch
            {
                sessionHandle = "";
            }
            
            //DO TEST WEB API===============================================================================================================================================
            //allegroService.doQuerySysStatus(3, 228, webAPIKey, out localVersion);
            //sessionHandle = allegroService.doLogin(login, password, 228, webAPIKey, localVersion, out userId, out serverTime);
            //==============================================================================================================================================================
        }

        //WLASCIWOSCI
        public string SESSIONHANDLE
        {
            get
            {
                return this.sessionHandle;
            }
            set { }
        }
        public int COUNTRYID
        {
            get
            {
                return this.countryId;
            }
            set { }
        }
        public string WEBAPIKEY
        {
            get
            {
                return this.webAPIKey;
            }
            set { }
        }
    }
}
