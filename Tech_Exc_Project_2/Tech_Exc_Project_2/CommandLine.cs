﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public class CommandLine : ICommandLine
    {
        private string angle;
        private string velocity;
        private string PlayerName;
        public string UserShotSelection;

        public void SetAngle()
        {
            Console.WriteLine("Please enter an angle between 1 and 90");
            angle = Console.ReadLine();
        }

        public string GetAngle()
        {
            return angle;
        }

        public void SetVelocity()
        {
            Console.WriteLine("Please enter a velocity between 1 and 20");
            velocity = Console.ReadLine();
        }

        public string GetVelocity()
        {
            return velocity;
        }

        public void SetPlayerName()
        {
            Console.WriteLine("Please enter a username to start: ");
            PlayerName = Console.ReadLine();
        }

        public string GetPlayerName()
        {
            return PlayerName;
        }

        public void SetShotSelection()
        {
            Console.WriteLine("Would you like to shoot with a Cannon or a Mortar?");
            Console.WriteLine("Please enter 1 for Cannon or 2 for Mortor");

            UserShotSelection = Console.ReadLine();
        }

        public string GetShotSelection()
        {
            return UserShotSelection;
        }
    }
}
