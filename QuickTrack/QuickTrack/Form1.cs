using Microsoft.VisualBasic;
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
            // Shows an input box to enter name and displays it, also will make JSON line for the runner with a code, makes a barcode for the runner's code
            string RunnerName = Interaction.InputBox("Enter runner's name:", "Add Runner", "Enter name here...");
            label2.Text = RunnerName;
            label2.Visible = true;
            var RunnerBarcode = BarcodeWriter.CreateBarcode(RunnerName, BarcodeEncoding.Code128);
            RunnerBarcode.AddBarcodeValueTextBelowBarcode();
            RunnerBarcode.SaveAsPng(RunnerName + "Barcode");
        }
    }
}
