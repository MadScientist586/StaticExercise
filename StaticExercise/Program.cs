using StaticExercise;
Console.WriteLine("Enter a number (fahrenheit):");
double userInput = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Your number is {TempConverter.FahrenheitToCelsius(userInput)} celsius.");

Console.WriteLine("Enter a number (celsius):");
double userInput2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Your number is {TempConverter.CelsiusToFahrenheit(userInput2)} fahrenheit.");
