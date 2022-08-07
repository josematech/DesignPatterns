namespace AbstractFactory
{
    public class MercedesFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new MercedeEQE();
        }

        public override Truck CreateTruck()
        {
            return new MercedesActrosF();
        }
    }
}