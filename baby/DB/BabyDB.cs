using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
     public class BabyDB
    {
        Baby baby = new Baby();

        public Baby babyinfo { get => baby; }

        DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<Baby>));

        public void SaveBaby()
        {
            using(FileStream fs = new FileStream("baby.json", FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.WriteObject(fs, baby);
            }
        }

        public BabyDB()
        {
            if (!File.Exists("baby.json"))
                return;
            using (FileStream fs = new FileStream("baby.json", FileMode.Open, FileAccess.Read))
            {
                baby = (Baby)JsonSerializer.ReadObject(fs);
            }
        }
    }
}
