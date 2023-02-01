using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tech_Exc_Project_2
{
    public class PopulateJson : IPopulateJson
    {
        private string path = @"C:\Users\Nathan.Dawson\OneDrive - Apexon\Documents\Tech-Track\Tech-Exc\Project_2\Tech_Exc_Project_2\Tech_Exc_Project_2\UserData.json";

        public void UpdateJson(string PlayerName, int Score, int TotalTime)
        {
            var CurrentJsonFile = File.ReadAllText(path);
            var UserDataList = JsonConvert.DeserializeObject<List<UserData>>(CurrentJsonFile);

            UserDataList.Add(new UserData()
            {
                UserName = PlayerName,
                FinalScore = Score,
                TimeElapsed = TotalTime
            });

            CurrentJsonFile = JsonConvert.SerializeObject(UserDataList, Formatting.Indented);
            File.WriteAllText(path, CurrentJsonFile);
        }

        public void PrintJson()
        {
            var CurrentJsonFile = File.ReadAllText(path);
            var UserDataList = JsonConvert.DeserializeObject<List<UserData>>(CurrentJsonFile);

            var lst = (from x in UserDataList
                       orderby x.FinalScore
                       select x).Take(5).ToList();

            Console.WriteLine("\n");
            Console.WriteLine("ScoreBoard: (Top 5 Players) ");
            foreach (var x in lst)
            {
                Console.WriteLine("Player Name: " + x.UserName);
                Console.WriteLine("Player Score: " + x.FinalScore);
                Console.WriteLine("Player's Time Taken " + x.TimeElapsed);
                Console.WriteLine("\n");
            }
        }
    }
}
