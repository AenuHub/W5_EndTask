## W5_EndTask - Car Factory
This is a C# console application that simulates the production of cars in a factory. The program allows users to 
create car objects by entering details like make, model, color, and number of doors. Each car's production date is 
automatically set to the current date and time. Users can create multiple cars in one session, with the program storing
each car in a list and displaying a summary of produced cars at the end.

### Features
- **Car Production**: Users are prompted to decide whether to produce a car. If they choose to proceed, they can enter 
various car details.
- **Automatic Production Date**: Each car's production date is automatically set to the moment of creation.
- **Data Validation**: Input validation for the "Number of Doors" field prevents exceptions due to non-numeric input, 
and an error message is shown for incorrect entries, using try-catch statements.
- **Multi-Car Creation**: Users can create multiple car objects in one session, with all created cars stored in a list.
- **Summary Display**: At the end of the session, the program displays the serial numbers, makes and models of all cars
created.

### Project Structure
- **Car.cs** - Defines the Car class with properties such as Production Date, Serial Number, Make, Model, Color, and 
Number of Doors.
- **Program.cs** - Contains the main logic, including user prompts, car production flow, data validation, and list 
management.
