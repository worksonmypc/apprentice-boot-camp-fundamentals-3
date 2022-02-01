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
                return GetEmissionChargeForVehicle(vehicle.Co2Emissions);
            }

            return 0;
        }

        private static int GetEmissionChargeForVehicle(int co2Emissions)
        {
            if (co2Emissions >= 1 &&
                co2Emissions <= 50)
                return 10;

            if (co2Emissions >= 51 &&
                co2Emissions <= 75)
                return 25;

            if (co2Emissions >= 76 &&
                co2Emissions <= 90)
                return 105;

            if (co2Emissions >= 91 &&
                co2Emissions <= 100)
                return 125;

            if (co2Emissions >= 101 &&
                co2Emissions <= 110)
                return 145;

            if (co2Emissions >= 111 &&
                co2Emissions <= 130)
                return 165;

            if (co2Emissions >= 131 &&
                co2Emissions <= 150)
                return 205;

            if (co2Emissions >= 151 &&
                co2Emissions <= 170)
                return 515;

            if (co2Emissions >= 171 &&
                co2Emissions <= 190)
                return 830;

            if (co2Emissions >= 191 &&
                co2Emissions <= 225)
                return 1240;

            if (co2Emissions >= 226 &&
                co2Emissions <= 255)
                return 1760;

            if (co2Emissions > 255)
                return 2070;
            
            return 0;
        }
    }
}