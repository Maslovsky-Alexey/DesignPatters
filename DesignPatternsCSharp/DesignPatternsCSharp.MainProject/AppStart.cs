using System;
using System.Collections;
using System.Linq;
using DesignPatternsCSharp.BaseStructure.Interfaces;
using DesignPatternsCSharp.MainProject.Helpers;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using DesignPatternsCSharp.CreationalPatterns.Modules.AbstractFactory;

namespace DesignPatternsCSharp.MainProject
{
    internal class AppStart
    {
        private static void LoadAllAssemblies()
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var loadedPaths = loadedAssemblies.Select(a => a.Location).ToArray();

            var referencedPaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            var toLoad = referencedPaths.Where(r => !loadedPaths.Contains(r, StringComparer.InvariantCultureIgnoreCase)).ToList();
            toLoad.ForEach(path => loadedAssemblies.Add(AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(path))));
        }

        private static IEnumerable<Type> GetAppModules()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.GetName().Name.EndsWith("Patterns"));

            return
                assemblies
                    .SelectMany(x => x.GetTypes(), (assembly, type) => type)
                    .Where(x => x.IsPublic && x.IsClass && (typeof(IAppModule).IsAssignableFrom(x)) && x.Name.EndsWith("AppModule"));
        }

        private static void Main(string[] args)
        {
            LoadAllAssemblies();

            var modules = GetAppModules();

            do
            {
                Console.Clear();

                for (var i = 0; i < modules.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {modules.ElementAt(i).Name}");
                }

                int number = 0;

                do
                {
                    Console.Write("Enter number of programm: ");

                    int.TryParse(Console.ReadLine(), out number);
                } while (number <= 0 || number > modules.Count());

                var module = (IAppModule)Activator.CreateInstance(modules.ElementAt(number - 1));
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(module.GetType().Name.Replace("AppModule", ""));
                Console.WriteLine("----------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Gray;

                module.Start();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Press 'Enter' to back to menu");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.ReadLine();
            } while (true);
        }
    }
}