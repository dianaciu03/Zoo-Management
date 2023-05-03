using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Linq;

namespace DataAccess
{
    public class ConnectionHelper
    {
        public string ConnectionValue()
        {
            return "Server=mssqlstud.fhict.local;Database=dbi520540_s2grp2zoo;User Id=dbi520540_s2grp2zoo;Password=ZooBazarGroup2; Encrypt=False; TrustServerCertificate=True;";
            //moved here for testing with asp razor pages since i cba finding where the app config is in razorpages
        }
    }
}
