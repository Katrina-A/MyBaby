using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    [Serializable]
    public class Baby
    {

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Birthday { get; set; }
    }
}
