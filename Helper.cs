using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BookNote
{
    public static class Helper
    {
        //We will use a getter to go get this value using the configuration Manager
        public static string connectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            }
        }
    }
}
