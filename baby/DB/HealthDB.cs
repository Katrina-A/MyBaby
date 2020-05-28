using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    public class HealthDB
    {
        List<Health> healths = new List<Health>();

        int AutoIncrement = 1;

        public List<Health> allHealthes { get => healths; }

        DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Health>));

        public void SaveHealth()
        {
            using(FileStream fs = new FileStream("health.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                json.WriteObject(fs, healths);
            }
        }
        
        public HealthDB()
        {
            if (!File.Exists("health.json"))
                return;
            using (FileStream fs = new FileStream("health.json", FileMode.Open, FileAccess.Read))
            {
                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                healths = (List<Health>)json.ReadObject(fs);
            }
        }

        public Health AddHealth()
        {
            var health = new Health { ID = AutoIncrement++ };
            healths.Add(health);
            return health;
        }
    }
}
