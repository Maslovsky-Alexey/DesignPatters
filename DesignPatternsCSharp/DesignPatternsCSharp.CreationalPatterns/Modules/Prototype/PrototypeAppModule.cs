using System;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.CreationalPatterns.Modules.Prototype.Body;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Prototype
{
    public class PrototypeAppModule : IAppModule
    {
        public void Start()
        {
            Console.WriteLine($"Initiated the creation of Man (Vasy).");
            var man = new European("Vasy");
            Console.WriteLine($"{man.Name} created");

            Console.WriteLine($"Initiated the cloning of Man (Igor).");
            var man1 = man.Clone();
            man1.Name = "Igor";

            Console.WriteLine($"{man1.Name} cloning");
        }
    }
}
