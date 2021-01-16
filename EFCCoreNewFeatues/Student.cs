using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCCoreNewFeatues
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
