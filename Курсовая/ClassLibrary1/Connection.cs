using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Internet
{
    public class Connection
    {
        public static bool ConnectionAvailable()
        {
            try
            {
                string strServer = "http://www.google.com";
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create(strServer);
                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode)
                {
                    rspFP.Close();
                    return true;
                }
                else
                {
                    rspFP.Close();
                    return false;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }
        public Connection()
        {
            
        }
    }
}
