namespace QuickTrack{
    public partial class Form1{
        // When pressed, make the time get stopped and have it search through the list of names, if the person doesn't already have a time saved, make it DNF
        string info;
        int updatetime = -1; // Classify as DNF if time is -1 in output
        string DNFRunner;

        public void FinishRace()
        {
            while (info = StreamReader.ReadLine(filePath) != null)
            {
                string[] allInfo = info.Split(',');
                string name = allInfo[0];
                int position = int.Parse(allInfo[1]);
                int time = int.Parse(allInfo[2]);

                if (time == 0)
                {
                    DNFRunner = Json.Serializer.Serialize(new { Name = name, Time = updatetime });
                    StreamWriter.WriteLine(line.Replace(info, DNFRunner));
                }
            }
            
            // Sorting by position, with DNF (-1) at the bottom
            var runners = new List<dynamic>(StreamReader.ReadTextAll(filePath));
                
            var sorted = runners.OrderBy(r => r.Time == -1 ? int.MaxValue : r.position)
                                .ThenBy(r => r.Time == -1 ? 0 : 1);

            foreach (var runner in sorted)
            {
                StreamWriter.WriteLine(Json.Serializer.Serialize(runner));
            }
        }           
    }
}

