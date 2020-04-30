using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    [DataContract]
    public class Baby
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Height { get; set; }
        [DataMember]
        public int Weight { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
    }
}
