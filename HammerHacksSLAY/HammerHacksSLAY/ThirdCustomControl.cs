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
    public partial class ThirdCustomControl : UserControl
    {

        private string[] quotes = new string[]
        {
        "Believe in yourself",
        "You can achieve anything",
        "Success is the result of hard work",
        "Stay positive, work hard, make it happen",
        "Every day is a new opportunity"

        };
        private Random random = new Random();
        
        public ThirdCustomControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string randomQuote = quotes[random.Next(quotes.Length)];    
            lblQuotes.Text = randomQuote;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string randomQuote = quotes[random.Next(quotes.Length)];
            lblQuotes.Text = randomQuote;

        }
    }
}
