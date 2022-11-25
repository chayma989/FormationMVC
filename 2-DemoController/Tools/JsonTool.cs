using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace _2_DemoController.Tools
{
    public class JsonTool
    {
        public static string ToJson<T>(T obj)
        {
            string result = null;
            DataContractJsonSerializer serial = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream())
            {
                serial.WriteObject(stream, obj);
                result = Encoding.UTF8.GetString(stream.ToArray());
            }



            return result;
        }


        
    }
}