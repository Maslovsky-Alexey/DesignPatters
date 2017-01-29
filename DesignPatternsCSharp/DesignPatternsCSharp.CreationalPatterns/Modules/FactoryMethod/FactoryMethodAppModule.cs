using System;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.CreationalPatterns.Modules.FactoryMethod.Body;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.FactoryMethod
{
    public class FactoryMethodAppModule : IAppModule
    {
        public void Start()
        {
            var family = new Family(3);

            Console.WriteLine($"Family created. Member count = {family.CountMembersFamily}");

            family.KillOneMember();

            Console.WriteLine($"Minus 1. Now, member count = {family.CountMembersFamily}");

            var child = family.CreateChild();

            Console.WriteLine($"New chiled ! name = {child.Name}");
            Console.WriteLine($"Plus 1. Now, member count = {family.CountMembersFamily}");
        }
    }
}
