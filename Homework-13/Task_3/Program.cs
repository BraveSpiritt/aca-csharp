namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            Car car = new Car("Toyota", "Corolla", 4);
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", false);
            car.DisplayInfo();
            motorcycle.DisplayInfo();
            Vehicle vehicleAsCar = car;
            Vehicle vehicleAsMotorcycle = motorcycle;
            vehicleAsCar.DisplayInfo();
            vehicleAsMotorcycle.DisplayInfo();
            if (vehicleAsCar is Car castedCar)
            {
                Console.WriteLine("Successfully casted to Car");
                castedCar.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Failed to cast to Car");
            }

            if (vehicleAsMotorcycle is Motorcycle castedMotorcycle)
            {
                Console.WriteLine("Successfully casted to Motorcycle");
                castedMotorcycle.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Failed to cast to Motorcycle");
            }

            try
            {
                Car invalidCast = (Car)vehicleAsMotorcycle;
                invalidCast.DisplayInfo();
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid cast from Motorcycle to Car");
            }
        }
        public class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public Vehicle(string make, string model)
            {
                Make = make;
                Model = model;
            }
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Vehicle: {Make} {Model}");
            }
        }
        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }

            public Car(string make, string model, int numberOfDoors)
                : base(make, model)
            {
                NumberOfDoors = numberOfDoors;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Car: {Make} {Model}, Doors: {NumberOfDoors}");
            }
        }
        public class Motorcycle : Vehicle
        {
            public bool HasSidecar { get; set; }

            public Motorcycle(string make, string model, bool hasSidecar)
                : base(make, model)
            {
                HasSidecar = hasSidecar;
            }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Motorcycle: {Make} {Model}, Sidecar: {HasSidecar}");
            }
        }
    }
}

