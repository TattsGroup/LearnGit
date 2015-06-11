using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().ReadFrom.AppSettings().CreateLogger();

            HttpClient client = new HttpClient();

            Log.Information("Making Request to Web Service");

            var result = client.GetStringAsync(new Uri("http://api.theysaidso.com/qod.js")).Result;

            Log.Information("Receive Response: {result}", result);

            Log.Debug("ClientApp Running.");
            Log.Debug("Enter to Quit.");
            Console.ReadLine();
        }
    }
}
