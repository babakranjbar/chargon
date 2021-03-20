using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProgram
{
    class Car : Vehicle , IParkable
    {
        Car(int ID) : base(ID) { }

        public int Entryhour
        {

            get
            {
                return Entryhour;
            }
            set
            {
                if (enterHour >= 1 & enterHour <= 24)
                {
                    Entryhour = enterHour;
                }
            }
        }

        public int ExitHour
        {
            get
            {
                return ExitHour;
            }
            set
            {
                if (exitHour >= 1 & exitHour <= 24)
                {
                    ExitHour = exitHour;
                }
            }
        }

        public int EntrancePrice(int EntrancePrice)
        {
            return EntrancePrice = 50000;
        }

        public int GetCost(int EntrancePrice, int Entryhour, int ExitHour, int HourPrice)
        {
            int Time = ExitHour - Entryhour;
            int perhours = Time * HourPrice;
            int GetCost = perhours + EntrancePrice;
            return GetCost;
        }

        public int HourPrice(int HourPrice)
        {
            return HourPrice = 20000;
        }
    }
}
