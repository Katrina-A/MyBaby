using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace baby
{
    public class EventDB
    {
        List<Event> events = new List<Event>();

        int AutoIncrement = 1;

        public List<Event> allEvent { get => events; }

        DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Event>));

        public void SaveEvent()
        {
            using (FileStream fs = new FileStream("event.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                json.WriteObject(fs, events);
            }
        }

        public EventDB()
        {
            if (!File.Exists("event.json"))
                return;
            using (FileStream fs = new FileStream("event.json", FileMode.Open, FileAccess.Read))
            {
                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                AutoIncrement = BitConverter.ToInt32(array, 0);
                events = (List<Event>)json.ReadObject(fs);
            }
        }


        public Event AddEvent()
        {
            var Event = new Event { ID = AutoIncrement++ };
            events.Add(Event);
            return Event;
        }
    }
}
