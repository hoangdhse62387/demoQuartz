
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;


namespace TestSchedule
{
    class Job : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            MessageBox.Show("Hệ thống lương đã được cập nhật");
        }
    }
}
