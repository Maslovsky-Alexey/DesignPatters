using System;
using System.IO;
using DesignPatternsCSharp.StructuralPatterns.Modules.Adapter.Body.Interfaces;

namespace DesignPatternsCSharp.StructuralPatterns.Modules.Adapter.Body
{
    public class FileAdapter : ILoger
    {
        public void Log(string text)
        {
            using (var sw = new StreamWriter("1.txt"))
            {
                sw.WriteLine(text);
            }
        }
    }
}
