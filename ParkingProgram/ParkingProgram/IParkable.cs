using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProgram
{
    interface IParkable
    {
        int Entryhour { get; set; }
        int ExitHour { get; set; }
        int EntrancePrice(int EntrancePrice);
        int HourPrice(int HourPrice);
        int GetCost(int EntrancePrice, int Entryhour, int ExitHour, int HourPrice);
    }
}
