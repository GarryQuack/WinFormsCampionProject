using System.Diagnostics;
using System.Windows.Forms;

namespace QuickTrack
{
    public partial class Form1 : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();

        public void StartRace()
        {
            // Starts the stopwatch to track time, starts the timer to update every second
            stopwatch.Restart();
            timer1.Start();
        }
    }
}