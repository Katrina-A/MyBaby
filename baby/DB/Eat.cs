using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    [DataContract]
    public class Eat
    {
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public DateTime Start { get; set; }
    }
}
