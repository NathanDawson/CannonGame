using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Exc_Project_2
{
    public interface ICommandLine
    {
        void SetAngle();
        string GetAngle();
        void SetVelocity();
        string GetVelocity();
        void SetPlayerName();
        string GetPlayerName();
        void SetShotSelection();
        string GetShotSelection();
    }
}
