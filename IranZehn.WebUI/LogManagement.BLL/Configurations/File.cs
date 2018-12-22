using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogManagement.BLL.Configurations
{
    public class File
    {
        public File(string fileName)
        {
            this.Filename = fileName;
        }

        public string Filename { get; set; }
    }
}
