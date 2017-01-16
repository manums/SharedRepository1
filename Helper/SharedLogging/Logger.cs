using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLogging
{
    public class Logger
    {
        public void WriteToFile(string filePath, string content)
        {
            if (!File.Exists(filePath))
                return;

            File.AppendAllLines(filePath, new string[] { content });
        }


        public void WriteToFile_New(string filePath, string content)
        {
            if (!File.Exists(filePath))
                return;

            File.AppendAllLines(filePath, new string[] { "#New#", content });
        }
    }
}
