using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Models;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Factories
{
    abstract class Factory
    {
        public abstract Product CreateProduct(string name);
    }
}
