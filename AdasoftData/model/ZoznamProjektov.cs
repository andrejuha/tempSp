using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdasoftData
{
    public class ZoznamProjektov<ProjectItem> : AdDocument
    {  
        IEnumerable<ProjectItem> Items { get; set; }
        public string  Xml { get; set; }

        public string Path { get; set; }
    }
}
