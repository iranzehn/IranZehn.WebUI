using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogManagement.BLL.Configurations
{
    public class Database
    {
        
        public Database(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

    }
}
