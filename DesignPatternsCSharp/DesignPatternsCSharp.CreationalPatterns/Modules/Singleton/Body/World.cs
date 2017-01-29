using System;

namespace DesignPatternsCSharp.CreationalPatterns.Modules.Singleton.Body
{
    public class World
    {
        public DateTime CreateDateTime { get; private set; }

        private static World world;

        private World()
        {
            CreateDateTime = DateTime.Now;
        }

        public static World GetWorld()
        {
            if (world == null)
            {
                world = new World();
            }

            return world;
        }
    }
}
