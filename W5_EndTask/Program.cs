using W5_EndTask;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("**** Welcome to the Car Factory ****");
        
        // list of cars
        List<Car> cars = new List<Car>();
        
        // bool check for user input
        bool shouldContinue = true;
        while (shouldContinue)
        {
            Console.Write("Do you want to create a new car? (y/n): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                cars.Add(CreateCar());
            }
            else if (input.ToLower() == "n")
            {
                shouldContinue = false;
                foreach (Car car in cars)
                {
                    car.DisplayInfo();
                }
                Console.WriteLine("Thank you for using the Car Factory. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }
        
        Console.ReadKey();
    }
    
    // creating new car with user input
    public static Car CreateCar()
    {
        Console.WriteLine("Please enter car details:");
        Console.Write("Serial number: ");
        int serialNumber = int.Parse(Console.ReadLine());
        Console.Write("Make: ");
        string make = Console.ReadLine();
        Console.Write("Model: ");
        string model = Console.ReadLine();
        Console.Write("Color: ");
        string color = Console.ReadLine();
        Console.Write("Number of doors: ");
        int numberOfDoors = 0;
        // bool check for user input
        bool isValid = false;
        while (!isValid)
        {
            try
            {
                numberOfDoors = int.Parse(Console.ReadLine());
                isValid = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        return new Car(serialNumber, make, model, color, numberOfDoors);
    }
}