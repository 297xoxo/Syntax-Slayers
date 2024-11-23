namespace HammerHacksSLAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Height = button1.Height;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            panel1.Height = button1.Height;
            firstCustomControl1.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            secondCustomControl1.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Height = button1.Height;
            thirdCustomControl1.BringToFront();

        }
    }
}
