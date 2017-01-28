using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Models;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Factories
{
    class FactoryB : Factory
    {
        public override Product CreateProduct(string name)
        {
            return new ProductB { Name = name };
        }
    }
}
