using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatanaIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      string uri = "http://Localhost:8080";

      using (WebApp.Start<Startup>(uri))
      {
        Console.WriteLine("Started!");
        Console.ReadKey();
        Console.WriteLine("Stoping!");
      }
    }


  }
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.UseWelcomePage();
      //TODO: LLegamos hasta The AppFunc del curso "ASP.NET MVC 5 Fundamentals" http://pluralsight.com/training/Player?author=scott-allen&name=aspdotnet-mvc5-fundamentals-m3-identity&mode=live&clip=0&course=aspdotnet-mvc5-fundamentals
      //app.Run(ctx =>
      //{
      //  return ctx.Response.WriteAsync("Hello World!");
      //});
    }
  }
}
