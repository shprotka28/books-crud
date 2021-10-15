﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.DataAccess
{
    /// <summary>
    /// Creates a connection to the database
    /// </summary>
    public class Helper
    {

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["cn"].ConnectionString; 

            }
        }
    }
}
