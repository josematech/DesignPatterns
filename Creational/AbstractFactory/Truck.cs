namespace AbstractFactory
{
    public abstract class Truck
    {
        public Truck()
        {
            Console.WriteLine($"{this.GetType().Name} truck model is created");
        }
    }
}