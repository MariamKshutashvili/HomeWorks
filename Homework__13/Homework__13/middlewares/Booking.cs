using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Homework__13.middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Booking
    {
        private readonly RequestDelegate _next;

        public Booking(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }

        private IConfiguration _configuration;
        public Booking (IConfiguration config)
        {
            _configuration = config;
        }
        
        [Route("/NoBooking", Name = "NoBooking")]
        public void On(AuthorizationFilterContext context)
        {
            var checkSwitch = _configuration.GetSection("Configurations").GetChildren()
                .FirstOrDefault(x => x.Key == "BookingNotAllowed");

            if (bool.Parse(checkSwitch.Value))
            {
                context.Result = new ViewResult() {ViewName = "NoBooking"};
            }

        }





    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class Middleware1Extensions
    {
        public static IApplicationBuilder UseMiddleware1(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Booking>();
        }
    }
}

