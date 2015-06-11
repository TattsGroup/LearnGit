using System;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using Serilog;

namespace ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.AppSettings().CreateLogger();

            Log.Debug("ServerApp Running.");
            Log.Debug("Enter to Quit.");
            Console.ReadLine();
        }
    }
}
