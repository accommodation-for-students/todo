using System;
using System.Collections.Generic;
using Quartz;

namespace TodoApp.Web.Extensions
{
    public class QuartzStartUp
    {
        private IScheduler _scheduler;
        private bool _started;
        private readonly Dictionary<IJobDetail, IReadOnlyCollection<ITrigger>> _triggersAndJobs;

        public QuartzStartUp(
            IScheduler scheduler,
            Dictionary<IJobDetail, IReadOnlyCollection<ITrigger>> triggersAndJobs)
        {
            _scheduler = scheduler;
            _triggersAndJobs = triggersAndJobs;
        }

        public void Start()
        {
            if (_started)
            {
                throw new InvalidOperationException("Already started.");
            }

            _scheduler.Start().Wait();

            _scheduler.ScheduleJobs(_triggersAndJobs, false);

            _started = true;
        }

        public void Stop()
        {
            if (_scheduler == null)
            {
                return;
            }

            if (_scheduler.Shutdown(true).Wait(30000))
            {
                _scheduler = null;
            }
        }
    }
}