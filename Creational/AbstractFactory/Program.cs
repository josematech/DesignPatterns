namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory renaultFactory = new RenaultFactory();
            VehicleOrder orderRenault = new VehicleOrder(renaultFactory);
            Console.WriteLine(String.Empty);

            VehicleFactory volvoFactory = new VolvoFactory();
            VehicleOrder orderVolvo = new VehicleOrder(volvoFactory);
            Console.WriteLine(String.Empty);

            VehicleFactory mercedesFactory = new MercedesFactory();
            VehicleOrder orderMercedes = new VehicleOrder(mercedesFactory);
            Console.WriteLine(String.Empty);

            Console.ReadKey();
        }
    }
}
