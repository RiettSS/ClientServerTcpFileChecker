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
    public static class Converter<T>
    {
        public static byte[] ToByteArray(T command) 
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

        
        public static T ToData(byte[] bytes)
        {
            var formatter = new BinaryFormatter();
            formatter.Binder = new CustomBinder();
            T command;

            using (var stream = new MemoryStream())
            {
                var bw = new BinaryWriter(stream);
                bw.Write(bytes);
                stream.Position = 0;
                command = (T)formatter.Deserialize(stream);
            }

            return command;
        }
    }
}
