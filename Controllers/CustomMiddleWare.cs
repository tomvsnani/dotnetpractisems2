namespace WebApplication2.Controllers
{
    public class CustomMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {


           await next(context);
        }
    }
}
