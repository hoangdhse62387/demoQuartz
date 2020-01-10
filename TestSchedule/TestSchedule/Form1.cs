using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Schedule sc = new Schedule();

        private void button1_Click(object sender, EventArgs e)
        {
            if (sc.checkScheduleStarted() == false)
            {
                sc.Start(int.Parse(txtHour.Text), int.Parse(txtMinute.Text));
                btnSchedule.Text = "Trạng thái chờ";
            }
            else
            {
                sc.Stop();
                btnSchedule.Text = "Tiến hành chờ";
            }
        }
    }
}
