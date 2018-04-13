using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Kanban.Api.DAL.DataContext;
using Kanban.Api.Common.Classes;
using Kanban.Api.Contracts.Interfaces.Services;
using Kanban.Api.BLL.Services;

namespace Kanban.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<KanbanDbContext>();
            services.AddTransient<KanbanDbInitializer>();

            //services.AddScoped(typeof(IAutoMapConverter<,>), typeof(AutoMapConverter<,>));
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<IBoardService, BoardService>();

            services.AddMvc();
            

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            

        }
    }
}
