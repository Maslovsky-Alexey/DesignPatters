using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Models
{
    abstract class Product
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Base product '{Name}'";
        }
    }
}
