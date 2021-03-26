using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var sw = new Stopwatch();
            sw.Start();

            var name = httpContext.Request.Query["name"];
            if (!String.IsNullOrEmpty(name))
            {
                httpContext.Request.Headers.Add("headerKey","headerValue");
            }
            
            await httpContext.Response.WriteAsync($"<p>{httpContext.Request.Scheme} {httpContext.Request.Path} {httpContext.Request.Host} {httpContext.Request.Method}</p>");
            await httpContext.Response.WriteAsync($" <h2>{sw.ElapsedMilliseconds}</h2>");
            await _next(httpContext);
        }
    }
    public static class CustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}