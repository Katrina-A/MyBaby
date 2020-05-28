using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    public class EatDB
    {
        public List<Eat> eats = new List<Eat>();

        int Autoincrement = 1;

        public List<Eat> allEats { get => eats; }

        DataContractJsonSerializer JsonSerializer = new DataContractJsonSerializer(typeof(List<Eat>));


        public void SaveEat()
        {
            using(FileStream fs = new FileStream("eat.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(Autoincrement), 0, 4);
                JsonSerializer.WriteObject(fs, eats);
            }
        }

        public EatDB()
        {
            if (!File.Exists("eat.json"))
                return;
            using(FileStream fs = new FileStream("eat.json", FileMode.Open, FileAccess.Read))
            {
                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                Autoincrement = BitConverter.ToInt32(array, 0);
                eats = (List<Eat>)JsonSerializer.ReadObject(fs);
            }
        }

        public Eat AddEat()
        {
            var eat = new Eat { ID = Autoincrement++ };
            eats.Add(eat);
            return eat;
        }
    }
}
