using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Prototype.Body
{
    public class European : Man
    {
        public European(string name) : base(name)
        {
        }

        public override Man Clone()
        {
            return (Man)MemberwiseClone();
        }
    }
}
