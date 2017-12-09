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

namespace MMLib.Demo.SOLIDPrinciples
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
            services.AddMvc();
            services.AddTransient<IPeopleImportService, PeopleImportService>();
            services.AddTransient<IPeopleReportService, PeopleReportService>();
            services.AddTransient<IMailServer, MailServer>();
            services.AddTransient<ILogger, Logger>();
            services.AddTransient<IReadOnlyPeopleRepository, DummyPeopleRepository>();
            services.AddTransient<IWritablePeopleRepository, PeopleRepository>();
        }

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
