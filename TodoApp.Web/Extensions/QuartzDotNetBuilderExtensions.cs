using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Impl;

namespace TodoApp.Web.Extensions
{
    public static class QuartzDotNetBuilderExtensions
    {
        public static void AddQuartzDotNet(this IServiceCollection services)
        {
            services.AddTransient<IScheduler>(serviceProvider =>
            {
                var scheduler = new StdSchedulerFactory().GetScheduler().Result;
                scheduler.JobFactory = new DotnetJobFactory(serviceProvider);
                return scheduler;
            });
        }

        public static void UseQuartzDotNet(this IApplicationBuilder app, IApplicationLifetime lifetime, Dictionary<IJobDetail, IReadOnlyCollection<ITrigger>> triggersAndJobs)
        {
            var scheduler = app.ApplicationServices.GetService<IScheduler>();

            var quartz = new QuartzStartUp(scheduler, triggersAndJobs);
            lifetime.ApplicationStarted.Register(quartz.Start);
            lifetime.ApplicationStopping.Register(quartz.Stop);
        }
    }
}
