namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Corolla", 4);
            Vehicle vehicleAsCar = car;  // Implicit cast
            vehicleAsCar.DisplayInfo();  // Output: Car: Toyota Corolla, Doors: 4

            Vehicle vehicle = new Vehicle("Generic", "Vehicle");
            Vehicle vehicleCar = new Car("Honda", "Civic", 4);
            Vehicle vehicleMotorcycle = new Motorcycle("Ducati", "Monster", false);

            if (vehicleCar is Car castedCar)
            {
                castedCar.DisplayInfo();  
            }

            try
            {
                Car invalidCast = (Car)vehicle;  
                invalidCast.DisplayInfo();
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid cast from Vehicle to Car");
            }

            Car safeCastedCar = vehicleCar as Car;
            if (safeCastedCar != null)
            {
                safeCastedCar.DisplayInfo();  
            }

         
            try
            {
                Motorcycle invalidMotorcycleCast = (Motorcycle)vehicleCar;  
                invalidMotorcycleCast.DisplayInfo();
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid cast from Vehicle to Motorcycle");
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
