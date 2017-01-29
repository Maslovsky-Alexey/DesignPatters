using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Builder.Body.Models
{
    public class Car
    {
        public string Whiles { get; set; }

        public string Body { get; set; }

        public string Windows { get; set; }

        public string Engine { get; set; }

        public override string ToString()
        {
            return $"Whiles = {Whiles}, Body = {Body}, Engine = {Engine}, Windows = {Windows}";
        }
    }
}
