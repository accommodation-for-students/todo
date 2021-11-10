using System;
using Quartz;
using Quartz.Simpl;
using Quartz.Spi;

namespace TodoApp.Web.Extensions
{
    public class DotnetJobFactory : SimpleJobFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DotnetJobFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public override IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            try
            {
                return (IJob)_serviceProvider.GetService(bundle.JobDetail.JobType);
            }
            catch (Exception e)
            {
                throw new SchedulerException($"Problem while instantiating job '{bundle.JobDetail.Key}' from the DotnetJobFactory.", e);
            }
        }
    }
}