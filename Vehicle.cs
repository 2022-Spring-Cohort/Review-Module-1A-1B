using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewModule1
{
    class Vehicle
    {
        public int TireCount;
        public string LicensePlate;
        public int AxleCount;
        public string FuelType;
        public int FuelLevel;

        public virtual void MoveVehicle()
        {
            this.FuelLevel--;
        }
    }

    class BMW : Vehicle
    {
        public string Color;
        public string VIN;
        public List<string> Parts;

        public BMW()
        {
            
        }

        public override void MoveVehicle()
        {

        }
    }
}
