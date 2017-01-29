using System;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.CreationalPatterns.Modules.Singleton.Body;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Singleton
{
    public class SingletonAppModule : IAppModule
    {
        public void Start()
        {
            var world = World.GetWorld();

            Console.WriteLine(world.CreateDateTime);
        }
    }
}
