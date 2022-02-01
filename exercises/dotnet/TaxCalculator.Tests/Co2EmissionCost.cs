namespace TaxCalculator.Tests
{
    public class Co2EmissionCost
    {
        public Co2EmissionCost(int? min, int? max, int petrolCost, int dieselCost, int alternativeFuelCost)
        {
            Min = min;
            Max = max;
            PetrolCost = petrolCost;
            DieselCost = dieselCost;
            AlternativeFuelCost = alternativeFuelCost;
        }

        public int? Min { get; }

        public int? Max { get; }

        public int PetrolCost { get; }

        public int DieselCost { get; }

        public int AlternativeFuelCost { get; }
    }
}