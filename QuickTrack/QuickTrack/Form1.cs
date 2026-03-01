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
            label2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            QueueBarcode(RunnerName);
            label2.Text = "Name Added";
            label2.Visible = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Adds a popup to confirm otherwise the user might print and THEN cancel, causing the names to be lost
            PopupForm popup = new PopupForm();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.Yes)
            {
                int result;
                result = PrintQueuedBarcodes();
                if (result == 1)
                {
                    label2.Text = "Printing...";
                }
                else { label2.Text = "No Names To Print"; }
            }
            else { label2.Text = "Printing Cancelled, names have still been saved"; }
            popup.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
