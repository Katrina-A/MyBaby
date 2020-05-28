using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    public class ActivityDB
    {
        List<Activity> Activities = new List<Activity>();

        int Inc = 1;

        public List<Activity> allActivity { get => Activities; }

     
        DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Activity>));

        public  void SaveActivity()
        {
            using(FileStream fs = new FileStream("activity.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(Inc), 0, 4);
                json.WriteObject(fs, Activities);
            }
        }

        public ActivityDB()
        {
            if (!File.Exists("activity.json"))
                return;
            using(FileStream fs = new FileStream("activity.json", FileMode.Open, FileAccess.Read))
            {
                    byte[] array = new byte[4];
                    fs.Read(array, 0, 4);
                    Inc = BitConverter.ToInt32(array, 0);
                    Activities = (List<Activity>)json.ReadObject(fs);
            }
        }

        public Activity AddActivity()
        {
            var activity = new Activity { ID = Inc++ };
            Activities.Add(activity);
            return activity;
        }
    }
}
