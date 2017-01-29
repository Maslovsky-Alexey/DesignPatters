using System;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.CreationalPatterns.Modules.Builder.Body;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Builder
{
    public class BuilderAppModule : IAppModule
    {
        public void Start()
        {
            var car = new CarBuilder()
                .CreateBody("Super")
                .CreateEngine("Puper")
                .CreateWhiles("Uber")
                .CreateWindows("None")
                .Build();

            Console.WriteLine(car);
        }
    }
}
