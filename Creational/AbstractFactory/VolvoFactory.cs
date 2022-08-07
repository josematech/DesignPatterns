namespace AbstractFactory
{
    public class VolvoFactory : VehicleFactory
    {
        public override Car CreateCar()
        {
            return new VolvoXc40Recharge();
        }

        public override Truck CreateTruck()
        {
            return new VolvoFH16();
        }
    }
}