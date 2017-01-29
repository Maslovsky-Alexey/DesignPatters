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
        private static IEnumerable<Type> GetAppModules()
        {
            AssemblyExtensions.LoadAllAssemblies();

            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(x => x.GetName().Name.EndsWith("Patterns"));

            return
                assemblies
                    .SelectMany(x => x.GetTypes(), (assembly, type) => type)
                    .Where(x => x.IsPublic && x.IsClass && (typeof(IAppModule).IsAssignableFrom(x)) && x.Name.EndsWith("AppModule"));
        }

        private static string GetModuleList(IEnumerable<Type> modules)
        {
            var result = "";

            for (var i = 0; i < modules.Count(); i++)
            {
                var name = modules.ElementAt(i).Name;
                result += $"{i + 1}. {name.Remove(name.Length - "ApModule".Length - 1)}\n";
            }

            return result;
        }

        private static void Main(string[] args)
        {
            var modules = GetAppModules().ToList();

            do
            {
                Console.Clear();

                Console.WriteLine(GetModuleList(modules));
                
                int number = 0;

                do
                {
                    Console.Write("Enter number of programm: ");

                    var s = Console.ReadLine();

                    if (!string.IsNullOrEmpty(s) && "exit".StartsWith(s))
                    {
                        return;
                    }

                    int.TryParse(s, out number);                 
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