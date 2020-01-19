using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Hotel.API.Middleware
{
	// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
	public class Middleware
	{
		private readonly RequestDelegate _next;

		public Middleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext httpContext, INotificationService notificationService)
		{
			notificationService.Notify($"Handling request: {httpContext.Request.Method} {httpContext.Request.Path}");
			await _next(httpContext);
			notificationService.Notify("Finished handling request.");
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
