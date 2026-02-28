using IronBarCode;

namespace QuickTrack
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
        private void button1_Click(object sender, EventArgs e)
        {
            var RunnerBarcode = BarcodeWriter.CreateBarcode(RunnerName, BarcodeEncoding.Code128);
            RunnerBarcode.AddBarcodeValueTextBelowBarcode();
        }
    }
}
