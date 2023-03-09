using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ZooBazaarLogicLibrary.Database
{
    public class ConnectioHelper
    {
        public string ConnectionValue()
        {
            return ConfigurationManager.ConnectionStrings["ZooBazarDB"].ConnectionString;
        }
    }
}
