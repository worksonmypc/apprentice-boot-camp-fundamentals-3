﻿using System;

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
                return GetEmissionChargeForVehicle(vehicle.Co2Emissions, vehicle.FuelType);
            }

            return 0;
        }

        private static int GetEmissionChargeForVehicle(int co2Emissions, FuelType fuelType)
        {
            if (co2Emissions >= 1 &&
                co2Emissions <= 50)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 10;
                    case FuelType.Diesel:
                        return 25;
                }
            }

            if (co2Emissions >= 51 &&
                co2Emissions <= 75)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 25;
                    case FuelType.Diesel:
                        return 105;
                }
            }

            if (co2Emissions >= 76 &&
                co2Emissions <= 90)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 105;
                    case FuelType.Diesel:
                        return 125;
                }
            }

            if (co2Emissions >= 91 &&
                co2Emissions <= 100)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 125;
                    case FuelType.Diesel:
                        return 145;
                }
            }

            if (co2Emissions >= 101 &&
                co2Emissions <= 110)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 145;
                    case FuelType.Diesel:
                        return 165;
                }
            }

            if (co2Emissions >= 111 &&
                co2Emissions <= 130)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 165;
                    case FuelType.Diesel:
                        return 205;
                }
            }

            if (co2Emissions >= 131 &&
                co2Emissions <= 150)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 205;
                    case FuelType.Diesel:
                        return 515;
                }
            }

            if (co2Emissions >= 151 &&
                co2Emissions <= 170)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 515;
                    case FuelType.Diesel:
                        return 830;
                }
            }

            if (co2Emissions >= 171 &&
                co2Emissions <= 190)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 830;
                    case FuelType.Diesel:
                        return 1240;
                }
            }

            if (co2Emissions >= 191 &&
                co2Emissions <= 225)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 1240;
                    case FuelType.Diesel:
                        return 1760;
                }
            }

            if (co2Emissions >= 226 &&
                co2Emissions <= 255)
            {
                switch (fuelType)
                {
                    case FuelType.Petrol:
                        return 1760;
                    case FuelType.Diesel:
                        return 2070;
                }
            }

            if (co2Emissions > 255)
                return 2070;
            
            return 0;
        }
    }
}