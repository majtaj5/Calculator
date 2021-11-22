using System;
using System.IO;

namespace calculator
{
    public class WorkingWithFiles
    {
        public string ReadTextFile(string textFilePath)
        {
            return File.ReadAllText(textFilePath);
        }
    }
}
