using System;

namespace TaxCalculator.Tests
{
    public class DefaultTaxCalculator : TaxCalculator
    {
        public DefaultTaxCalculator(int year) : base(year)
        {
            
        }

        public override int CalculateTax(Vehicle vehicle)
        {
            if (vehicle.DateOfFirstRegistration.Year == Year)
            {
                return GetEmissionChargeForVehicle(vehicle);
            }

            return 0;
        }

        private static int GetEmissionChargeForVehicle(Vehicle vehicle)
        {
            if (vehicle.Co2Emissions >= 1 &&
                vehicle.Co2Emissions <= 50)
                return 10;

            if (vehicle.Co2Emissions >= 51 &&
                vehicle.Co2Emissions <= 75)
                return 25;

            if (vehicle.Co2Emissions >= 76 &&
                vehicle.Co2Emissions <= 90)
                return 105;

            if (vehicle.Co2Emissions >= 91 &&
                vehicle.Co2Emissions <= 100)
                return 125;

            if (vehicle.Co2Emissions >= 101 &&
                vehicle.Co2Emissions <= 110)
                return 145;

            if (vehicle.Co2Emissions >= 111 &&
                vehicle.Co2Emissions >= 130)
                return 165;

            if (vehicle.Co2Emissions >= 131 &&
                vehicle.Co2Emissions <= 150)
                return 205;

            if (vehicle.Co2Emissions >= 151 &&
                vehicle.Co2Emissions <= 170)
                return 515;

            if (vehicle.Co2Emissions >= 171 &&
                vehicle.Co2Emissions <= 190)
                return 830;

            if (vehicle.Co2Emissions >= 191 &&
                vehicle.Co2Emissions <= 225)
                return 1240;

            if (vehicle.Co2Emissions >= 226 &&
                vehicle.Co2Emissions <= 255)
                return 1760;

            if (vehicle.Co2Emissions > 255)
                return 2070;
            
            return 0;
        }
    }
}