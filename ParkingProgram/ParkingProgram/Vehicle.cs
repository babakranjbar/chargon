using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProgram
{
    abstract class Vehicle
    {
        public Vehicle(int id) => ID = id;

        public int ID; //feild for id
        public enum VehicleType
        {
            car = 1,
            bike = 2
        }
    }
}
