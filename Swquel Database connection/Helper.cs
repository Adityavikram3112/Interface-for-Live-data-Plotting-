﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swquel_Database_connection
{
    public static class Helper
    {
        public static string CnnVal( string name )
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
