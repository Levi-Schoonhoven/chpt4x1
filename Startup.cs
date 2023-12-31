﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using chpt4x1.Models;



namespace chpt4x1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });

            


            services.AddControllersWithViews();
            
            services.AddDbContext<MovieContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MovieContext")));
        }
       
    }
}
