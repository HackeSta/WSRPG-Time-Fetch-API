using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSTimeFetch;
namespace WSTimeFetch_Test
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = 1;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            setTime(TimeFetch.getHour(), TimeFetch.getMinute());
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void setTime(int hour, int minute)
        {
            string _hour = ToTime(hour.ToString());
            string _minute = ToTime(minute.ToString());
            lblTime.Text = _hour + ":" + _minute;

        }

        private string ToTime(string text)
        {
            if (text.Length == 1)
            {
                text = "0" + text;
            }
            return text;
        }

        
    }
    
}
