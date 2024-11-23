using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammerHacksSLAY
{
    public partial class SecondCustomControl : UserControl
    {
        public SecondCustomControl()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {


            timer.Start();

        }
        int timeleft = 1500;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeleft > 0)
            {
                int minute = timeleft / 60;
                int second = timeleft % 60;
                timeleft = timeleft - 1;
                timerlabel.Text = minute + ":" + second + " minutes";

            }
            else
            {
                timer.Stop();
                timerlabel.Text = "Time is up";

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 1500;
            int minute = timeleft / 60;
            timerlabel.Text = minute + " minutes";

        }

        private void timerlabel_Click(object sender, EventArgs e)
        {

        }
    }

}
