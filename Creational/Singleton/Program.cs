using System;

namespace Singleton
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log("Hello...");
            Logger.Instance.Log("...I'm always using the same instance...");
            Logger.Instance.Log("...of the logger class");
            Console.ReadKey();
        }
    }
}
