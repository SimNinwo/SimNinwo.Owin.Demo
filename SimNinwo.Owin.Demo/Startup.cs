using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;

namespace SimNinwo.Owin.Demo
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app) // IAppBuilder interface used to add middleWares 
        {
            // middleware with katana
            app.Use(async (ctx, next) =>
            {
                await ctx.Response.WriteAsync("<html><head></head><body>Hello World</body></html>");
            });
        }
    }
}