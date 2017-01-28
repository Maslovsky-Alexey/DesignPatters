using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Models;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Factories
{
    class FactoryA : Factory
    {
        public override Product CreateProduct(string name)
        {
            return new ProductA { Name = name };
        }
    }
}
