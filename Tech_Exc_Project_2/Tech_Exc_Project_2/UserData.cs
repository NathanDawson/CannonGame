using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class UserData : IUserData
    {
        private string PlayerName;

        public string UserName { get; set; }
        public int FinalScore { get; set; }
        public int TimeElapsed { get; set; }

        public void SetPlayerName()
        {
            Console.WriteLine("Please enter a username to start: ");
            PlayerName = Console.ReadLine();
        }

        public string GetPlayerName()
        {
            return PlayerName; 
        }
    }
}
