using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DatabaseLogicLibrary
{
    public class ConnectionHelper
    {
        public string ConnectionValue()
        {
            return ConfigurationManager.ConnectionStrings["ZooDB"].ToString();
        }
    }
}
