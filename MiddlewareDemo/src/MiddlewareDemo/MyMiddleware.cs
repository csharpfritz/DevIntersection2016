using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
  public class MyMiddleware
  {

    public MyMiddleware(RequestDelegate next, string name)
    {
      this.Next = next;
      this.Name = name;
    }

    public RequestDelegate Next { get; }

    public string Name { get; }

    public Task Invoke(HttpContext context)
    {
      context.Response.Headers.Add("X-DevIntersection", $"{Name} was here");
      return Next(context);
    }

  }

  public static class MyMiddlewareExtensions
  {

    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app, string name)
    {

      return app.UseMiddleware<MyMiddleware>(name);

    }

  }
}
