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
        public List<Baby> baby = new List<Baby>();

        int AutoIncrement = 1;

        public List<Baby> babyinfo { get => baby; }

        DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<Baby>));

        public void SaveBaby()
        {
            using(FileStream fs = new FileStream("baby.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                JsonSerializer.WriteObject(fs, baby);
            }
        }

        public BabyDB()
        {
            if (!File.Exists("baby.json"))
                return;
            using (FileStream fs = new FileStream("baby.json", FileMode.Open, FileAccess.Read))
            {
                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                baby = (List<Baby>)JsonSerializer.ReadObject(fs);
            }
        }

        public Baby AddBaby()
        {
            var Baby = new Baby { ID = AutoIncrement++};
            baby.Add(Baby);
            return Baby;
        }
    }
}
