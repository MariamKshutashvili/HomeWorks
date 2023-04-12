using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Abstractions;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace Homework__13.middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Middleware
    {
        private readonly RequestDelegate _next;

        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

      
        private string jsonFile = Path.Combine(Directory.GetCurrentDirectory(), "information.json");

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.Value.Contains("/appointments"))
            {
                StreamReader streamReader = new(jsonFile);
                string jread = streamReader.ReadToEnd();
                await httpContext.Response.WriteAsync(jread);
            }
            else
            {
                await _next(httpContext);
            }
        }



    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
