using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Factories;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body
{
    class CreatorVasey
    {
        private readonly Factory factory;

        public CreatorVasey(Factory factory)
        {
            this.factory = factory;
        }

        public string CreateVasy()
        {
            return factory.CreateProduct("Vasy").ToString();
        }
    }
}
