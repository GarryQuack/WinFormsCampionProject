using System.Text;
using System.Text.Json;
using System.IO;

namespace QuickTrack{
    public partial class Form1{
        // When pressed, make the time get stopped and have it search through the list of names, if the person doesn't already have a time saved, make it DNF
        public void FinishRace()
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
                var r = JsonSerializer.Deserialize<Runner>(line);
                if (r == null)
                    continue;

                if (r.Time == 0)
                    r.Time = -1;

                runners.Add(r);
            }

            // Sort by making sure DNF is at the end then by position  
            var sorted = runners
                .OrderBy(r => r.Time == -1)
                .ThenBy(r => r.Position)
                .ToList();

            // Write all the runners back into file by position order, DNF at the end
            File.WriteAllLines(filePath, sorted.Select(r => JsonSerializer.Serialize(r)));
        }

        private class Runner
        {
            public string Name { get; set; }
            public int Position { get; set; }
            public int Time { get; set; }
        }
    }
}

