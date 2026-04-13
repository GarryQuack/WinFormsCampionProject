namespace QuickTrack
{
    public partial class Form1 : Form
    {
        public string RunnerName;

        public Form1()
        {
            InitializeComponent();
            originalFormSize = this.Size;
            foreach (Control control in this.Controls)
            {
                ControlBounds[control] = control.Bounds;
            }
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

        private void RaceStart_Click(object sender, EventArgs e)
        {
            StartRace();
            TimeKeeping.Text = "Race has started!";
            TimeKeeping.ForeColor = Color.Green;
        }

        private void ButtonFinishRace_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();

            TimeKeeping.Text = "Race has finished!";
            TimeKeeping.ForeColor = Color.Red;

            FinishRace();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.ffff");
        }

        private Size originalFormSize;
        private Dictionary<Control, Rectangle> ControlBounds = new Dictionary<Control, Rectangle>();

        private void Form1_Resize(object sender, EventArgs e)
        {
            float xRatio = (float)this.Size.Width / originalFormSize.Width;
            float yRatio = (float)this.Size.Height / originalFormSize.Height;
            foreach (Control control in this.Controls)
            {
                Rectangle originalBounds = ControlBounds[control];
                control.SetBounds(
                    (int)(originalBounds.X * xRatio),
                    (int)(originalBounds.Y * yRatio),
                    (int)(originalBounds.Width * xRatio),
                    (int)(originalBounds.Height * yRatio)
                );
            }
        }
    }
}
