using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // for validator

namespace MyBikesFactory.Business
{
    public static class Validator
    {
        // Serial number: numeric characters only
        public static bool ValidateSerialNumber(string inputToCheck)
        {
            return int.TryParse(inputToCheck, out _);
        }

        // sn: must be unique
        public static bool ValidateUniqueSerialNumber(string inputToCheck, List<Bike> listOfBikes)
        {
            int serialNumber = Convert.ToInt32(inputToCheck);

            foreach(var bike in listOfBikes)
            {
                if (bike.SerialNumber == serialNumber)
                    return false;
            }
            return true;
        }

        // Model: 5 characters (numbers or letters only).
        public static bool ValidateModel(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"\w{5}$");
        }


        // Manufacturing year: 4 characters (numbers only).
        public static bool ValidateManufacturingYear(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, "^[0-9]{4,4}$");
        }
    }
}
