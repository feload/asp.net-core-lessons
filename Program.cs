using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;
using asp.net_core_lessons.Data;
using Microsoft.Extensions.DependencyInjection;

namespace asp.net_core_lessons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args);

            // This allows us to populate the database with some fake data.
            using (var newScope = host.Services.CreateScope())
            {
                var context = newScope.ServiceProvider.GetRequiredService<AppDbContext>();
                DbInit.InitializeWithFakeData(context);
            }

            host.Run();
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
