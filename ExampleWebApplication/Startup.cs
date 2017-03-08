using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ExampleWebApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.Run(async ctx =>
            {
                // this call is displayed without syntax highlighting
                var result = ExampleLibrary.Utility.Test();

                await ctx.Response.WriteAsync(result);
            });
        }
    }
}
