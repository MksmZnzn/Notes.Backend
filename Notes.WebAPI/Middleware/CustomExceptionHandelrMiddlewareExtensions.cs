using System.Runtime.CompilerServices;

namespace Notes.WebAPI.Middleware
{
    public static class CustomExceptionHandelrMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
             return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}
