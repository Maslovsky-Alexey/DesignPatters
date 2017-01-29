using System;
using DesignPatternsCSharp.StructuralPatterns.Modules.Adapter.Body.Interfaces;

namespace DesignPatternsCSharp.StructuralPatterns.Modules.Adapter.Body
{
    public class ConsoleAdapter : ILoger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
