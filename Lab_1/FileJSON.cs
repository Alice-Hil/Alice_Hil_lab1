using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class FileJSON
    {
        public static void SafeTo(Counter counter)
        {
            string objectToSerialize = JsonConvert.SerializeObject(counter);
            File.WriteAllText("C:/Users/Алиса/source/repos/Lab_1/counter.json", objectToSerialize);
        }

        public static Counter ReadFrom(string path)
        {
            string json = File.ReadAllText("C:/Users/Алиса/source/repos/Lab_1/counter.json");
            Counter counter = JsonConvert.DeserializeObject<Counter>(json);
            return counter;
        }
    }
}
