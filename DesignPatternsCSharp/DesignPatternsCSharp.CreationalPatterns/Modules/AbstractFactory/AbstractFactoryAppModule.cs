using System;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body;
using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Factories;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory
{
    public class AbstractFactoryAppModule : IAppModule
    {
        public void Start()
        {
            CreatorVasey creatorVaseyA = new CreatorVasey(new FactoryA());
            CreatorVasey creatorVaseyB = new CreatorVasey(new FactoryB());

            Console.WriteLine($"FactoryA - ({creatorVaseyA.CreateVasy()})");
            Console.WriteLine($"FactoryB - ({creatorVaseyB.CreateVasy()})");
        }
    }
}
