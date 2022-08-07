namespace AbstractFactory
{
    public class RenaultFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new RenaultArkana();
        }

        public override Truck CreateTruck()
        {
            return new RenaultDWideGNC();
        }
    }
}