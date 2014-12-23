using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
 
public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.Use((context, next) =>
        {
           context.Response.ContentType = "text/plain";
           context.Response.WriteAsync("Hello ");
 
           return next.Invoke();
        });
 
        app.Run((HttpContext context) =>
        {
           return context.Response.WriteAsync("ASP.NET vNext");
        });
    }
}
