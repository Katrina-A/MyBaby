using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    [Serializable]
    public class Eat
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }
}
