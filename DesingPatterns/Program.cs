using System;
using DesingPatterns.Singleton;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var singleton = Singleton.Instance;
            var logger = Log.Logger;

            logger.Save("Anagrama");
        }
    }
}

