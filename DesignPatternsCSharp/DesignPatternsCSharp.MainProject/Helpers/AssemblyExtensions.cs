using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DesignPatternsCSharp.MainProject.Helpers
{
    public static class AssemblyExtensions
    {
        public static void LoadAllAssemblies()
        {
            var loadedPaths = AppDomain.CurrentDomain.GetAssemblies().Select(a => a.Location);

            var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase));

            foreach (var path in toLoad)
            {
                AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path));
            }
        }
    }
}
