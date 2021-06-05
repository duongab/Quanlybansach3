using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quanlybansach.Models
{
    public class Class2
    {
        public string machude { get; set; }

        
        public string tenchude { get; set; }

        public virtual ICollection<Sach> Sachs { get; set; }
        public HashSet<Chude> Chudes { get; }
    }
}