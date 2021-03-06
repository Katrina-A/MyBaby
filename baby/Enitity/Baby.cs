﻿using System;
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
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string Age { get; set; }
        [DataMember]
        public string Height { get; set; }
        [DataMember]
        public string Weight { get; set; }
        [DataMember]
        public string Birthday { get; set; }
        [DataMember]
        public Vaccinations Vaccinations { get; set; }
    }
}
