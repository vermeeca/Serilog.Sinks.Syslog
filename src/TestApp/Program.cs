using System;
using Serilog;
using Serilog.Sinks.Syslog;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YOUR_PORT_HERE = 0;
            const string YOUR_SYSLOG_HOST_HERE = "e.g. logsN.papertrailapp.com";

            var logger = new LoggerConfiguration()
                .WriteTo.Syslog(YOUR_SYSLOG_HOST_HERE, YOUR_PORT_HERE, 1)
                .CreateLogger();


            logger.Information("Test message");
            logger.Dispose();
        }
    }
}