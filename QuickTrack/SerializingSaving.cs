using System;
using System.IO;
using System.Text.Json;

namespace QuickTrack
{
	public partial class Form1
	{
		string filePath;
		bool fileMade = false;
		int Position { get; set; }
		int Time { get; set; }
		private void SerializingSaving(string name)
		{
			if (!fileMade)
			{
				// Creates a directory for the run save data 
				string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SavedRunData");
				Directory.CreateDirectory(directory);
				// Creates timestamp for the file naming so that in the multiple runs none get overwritten
				string safeTimestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");
				filePath = Path.Combine(directory, "runnerData" + safeTimestamp + ".json");
                // Sets fileMade to true so that it doesn't make a new file every time a runner is added, just updates the same file
                fileMade = true;
			}
			else
			{
				string jsonString = JsonSerializer.Serialize(new { Name = name, Position, Time });
				File.AppendAllText(filePath, jsonString + "\n");
			}
		}
	}
}