using MyBikesFactory.Business.Enums; // Access
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class MountainBike : Bike
    {
        private ESuspensionType _suspensionType;

        public ESuspensionType SuspensionType { get => _suspensionType; set => _suspensionType = value; }

        public MountainBike() : base()
        {
            _suspensionType = ESuspensionType.Undefined;
        }

        public MountainBike(ESuspensionType suspensionType) : base()
        {
            _suspensionType = suspensionType;
        }

        public override string ToString()
        {
            return "Bike Type: Mountain Bike, " + base.ToString() + $", Suspension Type: {_suspensionType}";
        }
    }
}
