using Server.Responses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Commands
{
    [Serializable]
    public class FileDownloader : ICommand
    {
        public string Path;

        public IResponse Perform()
        {
            ConsoleOut.WriteLine(Path);
            var bytes = File.ReadAllBytes(Path);

            try
            {
                File.WriteAllBytes("C:\\esdf.txt", bytes);
            } 
            catch(Exception e)
            {
                ConsoleOut.WriteLine("FileWriting:");
                ConsoleOut.WriteLine(e.Message);
            }


            var response = new FileDownloaderResponse();
            response.fileByteArray = bytes;

            return response;
        }
    }
}
