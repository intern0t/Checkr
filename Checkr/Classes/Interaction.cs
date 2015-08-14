using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Checkr.Classes
{
    public class Interaction
    {
        private static WebClient WebClient = null;

        public Interaction() { }

        public Interaction(string connection)
        {

        }

        public string Retrive(string _urlparameter)
        {
            string toReturn = string.Empty;
            using(WebClient = new WebClient())
            {
                toReturn = WebClient.DownloadString(_urlparameter);
            }

            if (string.IsNullOrEmpty(toReturn))
            {
                return "-";
            }
            else
            {
                return toReturn;
            }

        }

        public Boolean LoginValidate(string _servRet)
        {
            Boolean toReturn = false;

            if (!string.IsNullOrEmpty(_servRet))
            {
                if (_servRet.Contains("false"))
                {
                    toReturn = false;
                }
                else
                {
                    toReturn = true;
                }
            }
            else
            {
                toReturn = false;
            }

            return toReturn;
        }

        public Boolean CheckLogin(string _argString)
        {
            Boolean toReturn = false;

            if (string.IsNullOrEmpty(_argString))
            {
                toReturn = false;
            }
            else
            {
                string[] u_p = _argString.Split(',');

                string serverReturned = Retrive(u_p[0] + "," + u_p[1]);

                if(!string.IsNullOrEmpty(serverReturned))
                {
                    // Check if the returned string is NOT* empty.
                    if (LoginValidate(serverReturned))
                    {
                        toReturn = true;
                    }
                    else
                    {
                        toReturn = false;
                    }
                }else
                {
                    // If the returned string is empty!
                    toReturn = false;
                }
            }

            return toReturn;
        }
    }
}
