using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    [DataContract]
    public class Health
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public Vaccinations Vaccinations { get; set; }
        [DataMember]
        public string Time { get; set; }
    }
}
