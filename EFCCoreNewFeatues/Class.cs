using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCCoreNewFeatues
{
    public class Class
    {
        public int ClassID { get; set; }
        public string Title{ get; set; }
        public string Description { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
