using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

using System.Threading.Tasks;
using DataMaping.Attributes;

namespace DataMaping
{
    public class Test : MBase
    {
        [Key]
        public string Name { get; set; }
        public string Des { get; set; }
        public string sValue { get; set; }
        public string sValue2 { get; set; }
    }
}
