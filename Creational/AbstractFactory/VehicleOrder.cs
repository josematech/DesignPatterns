namespace AbstractFactory
{
    public class VehicleOrder
    {
        private Car car;
        private Truck truck;

        public VehicleOrder(VehicleFactory factory)
        {
            car = factory.CreateCar();
            truck = factory.CreateTruck();
        }
    }
}