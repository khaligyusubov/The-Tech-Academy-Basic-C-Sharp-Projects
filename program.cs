using System;

class ExpressCostEstimator
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get the cargo weight from user input
        Console.WriteLine("Please enter the package weight:");
        if (!double.TryParse(Console.ReadLine(), out double payload))
        {
            Console.WriteLine("Error: Please enter a valid numeric input.");
            return;
        }

        // Check for weight eligibility
        if (payload > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get width measurement
        Console.WriteLine("Please enter the package width:");
        if (!double.TryParse(Console.ReadLine(), out double breadth))
        {
            Console.WriteLine("Error: Please enter a valid numeric input.");
            return;
        }

        // Get height measurement
        Console.WriteLine("Please enter the package height:");
        if (!double.TryParse(Console.ReadLine(), out double elevation))
        {
            Console.WriteLine("Error: Please enter a valid numeric input.");
            return;
        }

        // Get length measurement
        Console.WriteLine("Please enter the package length:");
        if (!double.TryParse(Console.ReadLine(), out double depth))
        {
            Console.WriteLine("Error: Please enter a valid numeric input.");
            return;
        }

        // Check combined size constraints
        double combinedLength = breadth + elevation + depth;
        if (combinedLength > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Perform cost estimation using volume and weight
        double cost = (breadth * elevation * depth * payload) / 100;

        // Display calculated fee to the user
        Console.WriteLine("Your estimated total for shipping this package is: ${0:0.00}", cost);
        Console.WriteLine("Thank you!");
    }
}
