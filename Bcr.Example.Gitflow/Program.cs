using System;
using System.Reflection;

namespace Bcr.Example.Gitflow
{
    class Program
    {
        private static string GetVersionString()
        {
            var attr = Assembly
                .GetEntryAssembly()
                .GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false) 
                as AssemblyInformationalVersionAttribute[];
            return attr[0].InformationalVersion;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World! I am version {GetVersionString()}");
        }
    }
}
