using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    public class MoodDB
    {
        List<Mood> moods = new List<Mood>();

        int AutoIncrement = 1;

        public List<Mood> allMood { get => moods; }

        DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Mood>));

        public void SaveMood()
        {
            using(FileStream fs = new FileStream("mood.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                json.WriteObject(fs, moods);
            }
        }

        public MoodDB()
        {
            if (!File.Exists("mood.json"))
                return;
            using(FileStream fs = new FileStream("mood.json", FileMode.Open, FileAccess.Read))
            {
                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                moods = (List<Mood>)json.ReadObject(fs);
            }
        }

        public Mood AddMood()
        {
            var mood = new Mood { ID = AutoIncrement++ };
            moods.Add(mood);
            return mood;
        }
    }
}
