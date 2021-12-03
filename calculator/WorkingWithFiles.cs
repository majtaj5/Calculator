using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class WorkingWithFiles
    {
        private string[] GetFileToArray(string pathOfFile) => File.ReadAllLines(pathOfFile);
        public string ReadOneLineOfTextFile(string pathOfFile, int numberOfLine)
        {
            GetFileToArray(pathOfFile);
            while ((numberOfLine <= 0) || (numberOfLine > GetFileToArray(pathOfFile).Length))
            {
                Console.Write($"Out of Range, file has {GetFileToArray(pathOfFile).Length} lines. \nGet correct number of line: ");
                numberOfLine = int.Parse(Console.ReadLine());
            }
            return GetFileToArray(pathOfFile)[numberOfLine - 1];
        }
    }
}
