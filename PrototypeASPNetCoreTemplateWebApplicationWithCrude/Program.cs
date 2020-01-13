/*
  SQL2X Generated code based on a SQL Server Schema
  SQL2X Version: 0.d
  http://sql2x.azurewebsites.net/
  Generated Date: 09.03.2018 08:05:57
  Template: sql2x.PrototypeASPNetCoreWebApplication.Content_ProgramDOTcs
*/ 
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace PrototypeASPNetCoreTemplateWebApplicationWithCrude {
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }
        // TODO, this needs to change inside the sql2x prototype
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                //.UseIISIntegration() // Necessary for Azure. ( https://stackoverflow.com/questions/33645242/the-specified-cgi-application-encountered-an-error-and-the-server-terminated-the )
                .UseKestrel( o => {
                    o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(5);
                    o.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(5); }) // https://stackoverflow.com/questions/37474309/timeouts-with-long-running-asp-net-mvc-core-controller-httppost-method
                .Build();
        }
}
