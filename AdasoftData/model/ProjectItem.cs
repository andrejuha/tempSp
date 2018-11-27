using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdasoftData.model
{
   public class ProjectItem : AdItem, IProjectItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abreviation { get; set; }
        public string Customer { get; set; }

    }

   
}
