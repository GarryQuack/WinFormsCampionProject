using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace QuickTrack
{
    public partial class Form1
    {
        private readonly List<string> _queuedCodes = new();
        private int _currentPrintIndex;

        // Adds an entry to a queue not printing
        public void QueueBarcode(string textToEncode)
        {
            if (string.IsNullOrWhiteSpace(textToEncode))
                throw new ArgumentException("Text to encode must not be empty.", nameof(textToEncode));

            // Adds the runner to a JSON file for later reading and saving time and position
            SerializingSaving(textToEncode);

            // Stores the string of the runner to be turned into a barcode and printed later
            _queuedCodes.Add(textToEncode);
        }

        // Prints all the queued barcodes
        public int PrintQueuedBarcodes()
        {
            if (_queuedCodes.Count == 0)
                return -1;

            // Reset print index for new print job
            _currentPrintIndex = 0;
            var pd = new PrintDocument();
            pd.PrintPage += PrintQueuedPage;

            // Preview the page before it's printed
            using (var preview = new PrintPreviewDialog { Document = pd })
            {
                preview.ShowDialog(this);
            }

            // Show the print dialog to select printer and settings before finally printing
            using (var printDialog = new PrintDialog { Document = pd })
            {
                if (printDialog.ShowDialog(this) == DialogResult.OK)
                {
                    pd.Print();
                }
            }

            return 1;
        }

        // Puts the barcodes on the page 2x4 allowing saved paper and smaller size to fit the runners
        private void PrintQueuedPage(object sender, PrintPageEventArgs e)
        {
            // Sets the layout for the page, 2 columns and 4 rows, which can be edited
            int columns = 2, rows = 4, perPage = columns * rows;
            var bounds = e.MarginBounds;
            int cellW = bounds.Width / columns;
            int cellH = bounds.Height / rows;
            int padding = 8;
            // Font for the text under - do not remove otherwise it's cut in half
            var valueFont = new Font(FontFamily.GenericMonospace, 16, FontStyle.Regular);

            // Draws barcodes until page is full or no more needed to print, then adds more pages if needed
            int drawn = 0;
            for (int i = 0; i < perPage && _currentPrintIndex < _queuedCodes.Count; i++)
            {
                string code = _queuedCodes[_currentPrintIndex];

                // Creates the runner into a barcode, resizes, adds name underneath, and converts to bitmap
                using var bmp;

                // Finds the column and row for current barcode
                int col = i % columns;
                int row = i / columns;
                // Finds the top left corner of the cell including some padding
                int cellX = bounds.Left + col * cellW + padding;
                int cellY = bounds.Top + row * cellH + padding;
                // Calculates the available width and height for the barcode after padding
                int availW = cellW - padding * 2;
                int availH = cellH - padding * 2;

                // Scales the barcode while not squashing or stretching it
                float scale = Math.Min((float)availW / bmp.Width, (float)availH / bmp.Height);
                int drawW = (int)(bmp.Width * scale);
                int drawH = (int)(bmp.Height * scale);
                // Centers the barcode in the cell
                int drawX = cellX + (availW - drawW) / 2;
                int drawY = cellY + (availH - drawH) / 2;

                // Draws the barcode using all calculations
                e.Graphics.DrawImage(bmp, drawX, drawY, drawW, drawH);
                // Moves to next barcode and adds to count to make sure it doesn't go out of bounds
                drawn++;
                _currentPrintIndex++;
            }

            // If there are more barcodes needed to be printed, adds more pages
            e.HasMorePages = _currentPrintIndex < _queuedCodes.Count;

            // Clear queue after final page printed
            if (!e.HasMorePages)
                _queuedCodes.Clear();
        }


    }
}
