namespace W5_EndTask;

public class Car
{
    public DateTime ProductionDate { get; set; }
    public int SerialNumber { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int NumberOfDoors { get; set; }
    
    public Car(int serialNumber, string make, string model, string color, int numberOfDoors)
    {
        ProductionDate = DateTime.Now;
        SerialNumber = serialNumber;
        Make = make;
        Model = model;
        Color = color;
        NumberOfDoors = numberOfDoors;
    }
    
    // displaying car serial number, make and model
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Serial Number: {SerialNumber}");
        Console.WriteLine($"Car Make: {Make}");
        Console.WriteLine($"Car Model: {Model}");
        Console.WriteLine("------------------------");
    }
}