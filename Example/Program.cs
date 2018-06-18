using System;
using System.IO;

namespace Example
{
    /// <summary>
    /// This example is based on the bunnybenchmark
    /// https://github.com/dmitryhryppa/frameworks_test/tree/master/bunnymark
    /// </summary>
    class Program
    {        
        static void Main(string[] args)
        {
            // this is required to find SFML.dll.
            string dllDirectory = Path.GetFullPath("../../External");
            Environment.SetEnvironmentVariable("PATH", 
                Environment.GetEnvironmentVariable("PATH") + ";" 
                + dllDirectory);            

            // create and run app.
            Application app = new Application(800, 600, "Benchmark");
            app.Run();
        }
    }
}
