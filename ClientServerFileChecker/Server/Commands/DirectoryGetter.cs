using Server;
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
    public class DirectoryGetter : ICommand
    {
        public string Path;

        public IResponse Perform()
        {
            var directories = Directory.GetDirectories(Path);
            var files = Directory.GetFiles(Path);

            var result = directories.Concat(files);

            var response = new DirectoryGetterResponse();
            var builder = new StringBuilder();
            foreach(var file in result)
            {
                builder.Append(file);
                builder.Append(Environment.NewLine);
            }

            response.Response = builder.ToString();

            return response;
        }
    }
}
