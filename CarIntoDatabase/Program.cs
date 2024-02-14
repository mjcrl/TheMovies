namespace CarIntoDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car fordMustang = new Car("Ford", "Mustang", 1964, "This is a nice car dude, maybe a muscle car? It goes vroom vroom.");
            Car toyotaCorolla = new Car("Toyota", "Corolla", 1998, "This is also nice car. Very durable. Very classic.");
            Car hyundaiAccnt = new Car("Hyundai", "Accnt", 2000, "This is kinda trash bro. Rusts very quick. Not durable. 2/10.");

            CarRepository carRepository = new CarRepository();

            carRepository.Create(fordMustang); carRepository.Create(toyotaCorolla); carRepository.Create(hyundaiAccnt);
        }
    }
}
