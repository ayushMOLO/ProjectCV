using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCV
{
    internal class year
    {
        //string[] module;

        public string[] module { get; set; }

        public year() {
            module = new string[2];
            module[0] = "communcation";
            module[1] = "oop";
        }

        public year(string[] module)
        {
            this.module = module;
        }
    }
}
