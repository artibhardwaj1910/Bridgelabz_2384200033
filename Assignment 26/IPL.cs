using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace IPLCensorshipAnalyzer
{
    class Program
    {
        static void Main()
        {
            string jsonInputFile = "ipl_matches.json";
            string jsonOutputFile = "ipl_matches_censored.json";
            string csvInputFile = "ipl_matches.csv";
            string csvOutputFile = "ipl_matches_censored.csv";

            // Process JSON file
            if (File.Exists(jsonInputFile))
            {
                List<MatchData> matches = ReadJson(jsonInputFile);
                ApplyCensorship(matches);
                WriteJson(jsonOutputFile, matches);
                Console.WriteLine("Censored JSON file created successfully.");
            }

            // Process CSV file
            if (File.Exists(csvInputFile))
            {
                List<MatchData> matches = ReadCsv(csvInputFile);
                ApplyCensorship(matches);
                WriteCsv(csvOutputFile, matches);
                Console.WriteLine("Censored CSV file created successfully.");
            }
        }

        // Method to read JSON file
        static List<MatchData> ReadJson(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<MatchData>>(jsonContent);
        }

        // Method to write JSON file
        static void WriteJson(string filePath, List<MatchData> matches)
        {
            string jsonContent = JsonConvert.SerializeObject(matches, Formatting.Indented);
            File.WriteAllText(filePath, jsonContent);
        }

        // Method to read CSV file
        static List<MatchData> ReadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                return csv.GetRecords<MatchData>().ToList();
            }
        }

        // Method to write CSV file
        static void WriteCsv(string filePath, List<MatchData> matches)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(matches);
            }
        }

        // Method to apply censorship
        static void ApplyCensorship(List<MatchData> matches)
        {
            foreach (var match in matches)
            {
                match.Team1 = MaskTeamName(match.Team1);
                match.Team2 = MaskTeamName(match.Team2);
                match.Winner = MaskTeamName(match.Winner);
                match.PlayerOfMatch = "REDACTED";

                // Update score dictionary keys
                Dictionary<string, int> newScores = new Dictionary<string, int>();
                foreach (var entry in match.Score)
                {
                    newScores[MaskTeamName(entry.Key)] = entry.Value;
                }
                match.Score = newScores;
            }
        }

        // Method to mask team names
        static string MaskTeamName(string teamName)
        {
            string[] words = teamName.Split(' ');
            if (words.Length > 1)
            {
                words[words.Length - 1] = "***";
            }
            return string.Join(" ", words);
        }
    }

    // Class to represent match data
    public class MatchData
    {
        public int MatchId { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public Dictionary<string, int> Score { get; set; }
        public string Winner { get; set; }
        public string PlayerOfMatch { get; set; }
    }
}
