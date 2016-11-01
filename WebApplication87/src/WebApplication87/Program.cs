using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace WebApplication87
{
  public class Program
  {
    public static void Main(string[] args)
    {

      var contentRoot = Directory.GetCurrentDirectory();

      var config = new ConfigurationBuilder()
        .SetBasePath(contentRoot)
        .AddJsonFile("hosting.json", optional: true)
        .Build();


      var host = new WebHostBuilder()
          //.UseKestrel()
          .UseWebListener()
          .UseContentRoot(contentRoot)
          .UseConfiguration(config)
          .UseIISIntegration()
          .UseStartup<Startup>()
          .Build();

      host.Run();
    }
  }
}
