namespace QuickTrack
{
    public partial class Form1 : Form
    {
        public string RunnerName;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RunnerName = textBox1.Text;
            label2.Text = RunnerName;
            label2.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PrintBarcode(RunnerName);
        }
    }
}
