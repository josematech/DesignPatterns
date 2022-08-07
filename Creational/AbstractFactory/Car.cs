namespace AbstractFactory
{
    public abstract class Car
    {
        public Car()
        {
            Console.WriteLine($"{this.GetType().Name} car model is created");
        }
    }
}