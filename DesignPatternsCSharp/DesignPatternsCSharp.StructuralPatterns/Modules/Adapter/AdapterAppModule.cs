using System;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.StructuralPatterns.Modules.Adapter.Body;
using DesignPatternsCSharp.StructuralPatterns.Modules.Adapter.Body.Interfaces;

namespace DesignPatternsCSharp.StructuralPatterns.Modules.Adapter
{
    public class AdapterAppModule : IAppModule
    {
        public void Start()
        {
            Console.WriteLine("Log in console and file (1.txt)");

            ILoger logerFile = new FileAdapter();
            ILoger logerConsole = new ConsoleAdapter();

            logerFile.Log("Hello world");
            logerConsole.Log("Hello world");
        }
    }
}
