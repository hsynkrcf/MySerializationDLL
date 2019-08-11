using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerilestirLib
{
    public class SerilestirXml
    {
        public void XmlSerialize<T>(T dataToSerialize, string filePath)
        {
            FileStream stream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            serializer.Serialize(writer, dataToSerialize);
            writer.Close();
        }
        public T XmlDeserialize<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            T serializedData = (T)serializer.Deserialize(stream);
            return serializedData;
        }
    }
}
