using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.MainProject.Helpers
{
    public static class ObjectExtensions
    {
        public static bool ContainsInterface(this object sender, Type type)
        {
            return sender
                .GetType()
                .GetInterfaces()
                .Contains(type);
        }
    }
}
