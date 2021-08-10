using System;
using System.Text;

namespace ExtractFile
{
    class ExtractFile
    {
        static void Main(string[] args)
        {
            StringBuilder filePath = new StringBuilder(Console.ReadLine());
            int indexLastSlash = filePath.ToString().LastIndexOf('\\');
            filePath.Remove(0, indexLastSlash + 1);
            int indexPoint = filePath.ToString().IndexOf('.');
            Console.WriteLine($"File name: {filePath.ToString().Substring(0, indexPoint)}\nFile extension: {filePath.ToString().Substring(indexPoint + 1)}");
        }
    }
}
