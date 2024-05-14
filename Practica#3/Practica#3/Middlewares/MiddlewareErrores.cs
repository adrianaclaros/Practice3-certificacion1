using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Practica_3.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareErrores : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                // Intenta procesar la solicitud
                await next(context);
            }
            catch (Exception ex)
            {
                // Maneja la excepción y crea una respuesta de error
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}