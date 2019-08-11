using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace SerilestirLib
{
    public class SerilestirJson
    {
        public void JsonSerializer<T>(T data, string filePath)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            FileStream stream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite);
            serializer.WriteObject(stream, data);
            stream.Close();
        }
        public T JsonDeserialize<T>(string filePath)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite);
            T obj = (T)serializer.ReadObject(stream);
            return obj;
        }
    }
}
