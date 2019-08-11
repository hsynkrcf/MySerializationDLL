using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerilestirLib
{
    public class SerilestirBinary
    {
        public void BinarySerialize<T>(T data, string path)
        {
            FileStream FS = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(FS, data);
        }

        public T BinaryDeserialize<T>(string filePath)
        {
            BinaryFormatter bs = new BinaryFormatter();
            FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite);
            T deserialized = (T)bs.Deserialize(fs);
            return deserialized;
        }
    }
}
