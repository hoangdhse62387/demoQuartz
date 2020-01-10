using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace TestSchedule
{
    class Schedule
    {
        IScheduler scheduler;
        IJobDetail job;
        ITrigger trigger;

        public void Start(int hour, int minute)
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            job = JobBuilder.Create<Job>().Build();

            trigger = TriggerBuilder.Create()
                .WithDailyTimeIntervalSchedule(
                    s =>
                        s.WithIntervalInHours(24)
                        .OnEveryDay()
                        .StartingDailyAt(TimeOfDay.HourAndMinuteOfDay(hour,minute))
                ).Build();
            scheduler.ScheduleJob(job, trigger);
        }

        public bool checkScheduleStarted()
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
            return scheduler.IsStarted;
        }

        public void Stop()
        {
            if (scheduler.IsStarted)
            {
                scheduler.Shutdown();
            }
        }
    }
}
