using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogManagement.BLL.Configurations
{
    public class Configurations
    {
        public Configurations()
        {
            Database = null;
            Email= null;
            File= null;
            EventLog= null;
        }
        public Database Database { get; set; }
        public File File { get; set; }
        public Email Email{ get; set; }
        public EventLog EventLog{ get; set; }
    }
}
