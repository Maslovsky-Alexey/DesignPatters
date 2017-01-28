using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory.Body.Models
{
    class ProductB : Product
    {
        public override string ToString()
        {
            return $"ProductB '{Name}'";
        }
    }
}
