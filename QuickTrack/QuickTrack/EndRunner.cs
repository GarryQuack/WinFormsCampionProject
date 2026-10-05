using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace QuickTrack
{
    public partial class Form1
    {
        int latestPosition = 0;
        public void EndRunner(string name)
        {
            if (filePath == null || new FileInfo(filePath).Length == 0)
            {
                MessageBox.Show("No runners have been added yet.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            var runners = new List<Runner>();

            foreach (var line in lines)
            {
                var runner = JsonSerializer.Deserialize<Runner>(line);
                if (runner.Name == name)
                {
                    runner.Position = ++latestPosition;
                    runner.Time = (int)stopwatch.Elapsed.TotalMilliseconds;
                }
                runners.Add(runner);
            }
            File.WriteAllLines(filePath, runners.Select(r => JsonSerializer.Serialize(r)));
        }
    }
}
