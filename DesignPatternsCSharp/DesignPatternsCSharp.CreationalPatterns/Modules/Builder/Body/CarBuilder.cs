using System;
using DesignPatternsCSharp.CreationalPatterns.Modules.Builder.Body.Models;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Builder.Body
{
    public class CarBuilder
    {
        private readonly Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public CarBuilder CreateWhiles(string whileName)
        {
            car.Whiles = whileName;
            return this;
        }

        public CarBuilder CreateBody(string bodyName)
        {
            car.Body = bodyName;
            return this;
        }

        public CarBuilder CreateWindows(string windowName)
        {
            car.Windows = windowName;
            return this;
        }

        public CarBuilder CreateEngine(string engineName)
        {
            car.Engine = engineName;
            return this;
        }

        public Car Build()
        {
            if (string.IsNullOrEmpty(car.Body) || string.IsNullOrEmpty(car.Engine) || string.IsNullOrEmpty(car.Whiles))
            {
                throw new InvalidOperationException("Body, engine and whiles are require!");
            }

            return car;
        }
    }
}
