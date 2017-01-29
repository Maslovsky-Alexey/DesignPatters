using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Prototype.Body
{
    public abstract class Man
    {
        public string Name { get; set; }

        protected Man(string name)
        {
            Name = name;

            Console.WriteLine($"Creating... Please wait");

            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");        
            }

            Console.WriteLine();
        }

        public abstract Man Clone();
    }
}
