using Microsoft.VisualBasic.Devices;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);

        }
        public string PassedText
        {
            get { return label1.Text; }
            set { label1.Text = "It's " + value; }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
            label4.Text = "Waiting";
            label3.Text = "Thinking";
            await Task.Delay(5000);
            label3.Text = "Using algorithms";
            await Task.Delay(5000);
            label3.Text = "I think you are thinking about this:";
            label4.Text = textBox1.Text;
            textBox1.Enabled = true;
            textBox1.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }
    }
}