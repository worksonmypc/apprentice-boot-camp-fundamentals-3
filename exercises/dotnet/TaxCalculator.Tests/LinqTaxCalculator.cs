using System.Collections.Generic;
using System.Linq;

namespace TaxCalculator.Tests
{
    public class LinqTaxCalculator : TaxCalculator
    {
        private const int ExpensiveVehicleThreshold = 40000;

        private readonly List<Co2EmissionCost> _co2EmissionCosts = new List<Co2EmissionCost>()
        {
            new Co2EmissionCost(0, 0, 0,0,0),
            new Co2EmissionCost(1, 50, 10, 25, 0),
            new Co2EmissionCost(51, 75, 25, 105, 15),
            new Co2EmissionCost(76, 90, 105, 125, 95),
            new Co2EmissionCost(91, 100, 125, 145, 115),
            new Co2EmissionCost(101, 110, 145, 165, 135),
            new Co2EmissionCost(111, 130, 165, 205, 155),
            new Co2EmissionCost(131, 150, 205, 515, 195),
            new Co2EmissionCost(151, 170, 515, 830, 505),
            new Co2EmissionCost(171, 190, 830, 1240, 820),
            new Co2EmissionCost(191, 225, 1240, 1760, 1230),
            new Co2EmissionCost(226, 255, 1760, 2070, 1750),
            new Co2EmissionCost(256, null, 2070, 2070, 2060)
        };

        public LinqTaxCalculator(int year) : base(year)
        {
            
        }

        public override int CalculateTax(Vehicle vehicle)
        {
            if (vehicle.DateOfFirstRegistration.Year == Year)
            {
                return GetEmissionChargeForVehicle(vehicle);
            }

            if (vehicle.ListPrice <= ExpensiveVehicleThreshold)
            {
                switch (vehicle.FuelType)
                {
                    case FuelType.Petrol:
                    case FuelType.Diesel:
                        return 140;
                    case FuelType.AlternativeFuel:
                        return 130;
                    default:
                        return 0;
                }
            }

            if (vehicle.ListPrice > ExpensiveVehicleThreshold)
            {
                switch (vehicle.FuelType)
                {
                    case FuelType.Petrol:
                    case FuelType.Diesel:
                        return 450;
                    case FuelType.Electric:
                        return 310;
                    case FuelType.AlternativeFuel:
                        return 440;
                    default:
                        return 0;
                }
            }

            return 0;
        }

        private int GetEmissionChargeForVehicle(Vehicle vehicle)
        {
            switch (vehicle.FuelType)
            {
                case FuelType.Petrol:
                    return _co2EmissionCosts
                        .Where(_ => vehicle.Co2Emissions >= _.Min && (vehicle.Co2Emissions <= _.Max || _.Max == null))
                        .Select(_ => _.PetrolCost)
                        .FirstOrDefault();
                case FuelType.Diesel:
                    return _co2EmissionCosts
                        .Where(_ => vehicle.Co2Emissions >= _.Min && (vehicle.Co2Emissions <= _.Max || _.Max == null))
                        .Select(_ => _.DieselCost)
                        .FirstOrDefault();
                case FuelType.AlternativeFuel:
                    return _co2EmissionCosts
                        .Where(_ => vehicle.Co2Emissions >= _.Min && (vehicle.Co2Emissions <= _.Max || _.Max == null))
                        .Select(_ => _.AlternativeFuelCost)
                        .FirstOrDefault();
            }

            return 0;
        }
    }
}