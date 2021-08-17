namespace FuelConsumptionCalculator
{
    public class Car
    {
        double startKilometers;
        double endKilometers;
        double _liters;
        public Car(double startOdo, double endingOdo, double liters)
        {
            startKilometers = startOdo;
            endKilometers = endingOdo;
            _liters = liters;
        }

        public double CalculateConsumption()
        {
            return _liters / (endKilometers - startKilometers);
        }

        private double ConsumptionPer100Km()
        {
            return CalculateConsumption() * 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            startKilometers = mileage;
            endKilometers += mileage;
            _liters += liters;
        }
    }
}
