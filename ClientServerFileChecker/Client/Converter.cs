using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Client;


namespace Server
{
    public static class Converter
    {
        public static byte[] ToByteArray(Data command) 
        {
            var formatter = new BinaryFormatter();
            byte[] bytes;

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, command);
                bytes = stream.ToArray();
            }

            return bytes;            
        }

        public static Data ToData(byte[] bytes)
        {
            var formatter = new BinaryFormatter();
            formatter.Binder = new CustomBinder();
            Data command;

            using (var stream = new MemoryStream())
            {
                var bw = new BinaryWriter(stream);
                bw.Write(bytes);
                stream.Position = 0;
                command = (Data)formatter.Deserialize(stream);
            }

            return command;
        }
    }
}
