using Microsoft.AspNetCore.Hosting;
using System;

namespace Web.RC1
{
    public static class Program
    {
        // Entry point for the application.
        public static void Main(string[] args)
        {
            Console.WriteLine("Configuring....");

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseDefaultHostingConfiguration(args)
                .UseStartup<Startup>()
                .Build();

            Console.WriteLine("Starting up....");

            host.Run();

            Console.WriteLine("Stopping....");
        }
    }
}
