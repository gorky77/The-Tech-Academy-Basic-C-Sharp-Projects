using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompting user for the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Checking if the weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();

            }

            // Prompting user for the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Prompting user for the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Prompting user for the package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Checking if the total dimensions are greater than 50
            int totalDimensions = width + height + length;
            if (totalDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }

            // Calculating the quote
            int dimensionsProduct = width * height * length;
            decimal quote = (dimensionsProduct * weight) / 100m;

            // Displaying the quote to the user
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
            Console.WriteLine("Thank you!");

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
