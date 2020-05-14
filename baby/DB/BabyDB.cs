using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
     public class BabyDB
    {
        public List<Baby> baby { get; set; } = new List<Baby>();
        public string filename = "baby.all";
        BinaryFormatter bf = new BinaryFormatter();


        public void Load()
        {
            if (!File.Exists(filename))
                return;
            using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bf.Deserialize(fileStream);
            }
        }

        public void Save()
        {
            using (FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fileStream, baby);
            }
        }

        public Baby AddBaby()
        {
            Baby _baby = new Baby
            {
                Name = "Имя ребенка"
            };
            baby.Add(_baby);
            return _baby;

        }
    }
}
