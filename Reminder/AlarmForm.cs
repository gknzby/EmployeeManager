using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneProje.Reminder
{

    public partial class AlarmForm : Form
    {
        bool color = true;
        int timer = 0;
        int index;
        ReminderManager remMng;
        public AlarmForm(int _index, ReminderManager _remMng)
        {
            InitializeComponent();
            index = _index;
            remMng = _remMng;
            lblRemind.Text = remMng.RemList[index].Title;
        }


        private void DoneReminder(object sender, EventArgs e)
        {
            remMng.RemList[index].Done = 1;
            remMng.SaveReminders();
            this.Close();
        }

        private void SilienceReminder(object sender, EventArgs e)
        {
            remMng.RemList[index].Done = -1;
            this.Close();
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            timer += 200;
            if (2000 < timer)
            {
                this.BackColor = Color.White;
                timerAlarm.Enabled = false;
            }
            else
            {
                if (color)
                {
                    this.BackColor = Color.Red;
                }
                else
                {
                    this.BackColor = Color.White;
                }
                color = !color;
            }

        }
    }
}
