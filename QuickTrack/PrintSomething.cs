using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using IronBarCode;

namespace QuickTrack
{
    public partial class Form1
    {
        private Bitmap _barcodeBitmap;

        public void PrintBarcode(string textToEncode)
        {
            if (string.IsNullOrWhiteSpace(textToEncode))
                throw new ArgumentException("Text to encode must not be empty.", nameof(textToEncode));

            // Creating the barcode
            _barcodeBitmap = BarcodeWriter
                .CreateBarcode(textToEncode, BarcodeEncoding.Code39)
                .AddBarcodeValueTextBelowBarcode()
                .ResizeTo(300,100)
                .SetMargins(10)
                .ToBitmap();

            // Preparing printing
            var pd = new PrintDocument();
            pd.PrintPage += PrintSomething;

            // Shows a preview to the user before printing
            using (var preview = new PrintPreviewDialog { Document = pd })
            {
                preview.ShowDialog(this);
            }
        }

        // Draws the barcode on the print page
        private void PrintSomething(object sender, PrintPageEventArgs e)
        {
            if (_barcodeBitmap != null)
            {
                // Finding bounds and placing the barcode in one of 8 spaces
                var bounds = e.MarginBounds;
                float scale = Math.Min(1f, (float)bounds.Width / _barcodeBitmap.Width);
                int drawWidth = (int)(_barcodeBitmap.Width * scale);
                int drawHeight = (int)(_barcodeBitmap.Height * scale);
                int x = bounds.Left;
                //int x = bounds.Left + (bounds.Width - drawWidth);
                int y = bounds.Top + (bounds.Height - drawHeight) / 4;
                e.Graphics.DrawImage(_barcodeBitmap, x, y, drawWidth, drawHeight);
            }

            e.HasMorePages = false;
        }
    }
}
