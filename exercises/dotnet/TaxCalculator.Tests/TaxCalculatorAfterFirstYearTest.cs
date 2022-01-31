﻿using System;
using NUnit.Framework;

namespace TaxCalculator.Tests
{
    [Ignore("Not yet implemented")]
    class TaxCalculatorAfterFirstYearTest
    {
        private static readonly DateTime FirstOfApril2017 = new DateTime(2017, 4, 1);
        private TaxCalculator _taxCalculator;

        [SetUp]
        public void BeforeEach()
        {
            _taxCalculator = new DummyTaxCalculator();
        }

        [Test]
        public void WhenVehicleUsesPetrol()
        {
            Vehicle vehicle = new Vehicle(206, FuelType.Petrol, FirstOfApril2017, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(140, tax);
        }

        [Test]
        public void WhenVehicleIsElectric()
        {
            Vehicle vehicle = new Vehicle(206, FuelType.Electric, FirstOfApril2017, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(0, tax);
        }

        [Test]
        public void WhenVehicleUsesAlternativeFuel()
        {
            Vehicle vehicle = new Vehicle(206, FuelType.AlternativeFuel, FirstOfApril2017, 20000);
            int tax = _taxCalculator.CalculateTax(vehicle);
            Assert.AreEqual(130, tax);
        }
    }
}
