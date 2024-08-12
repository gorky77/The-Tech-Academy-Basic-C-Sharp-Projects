using System;

namespace StringArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a one-dimensional array of strings
            string[] myArray = { "Gorkem", "Whats", "Doing", "Here" };

            // Ask the user to input some text
            Console.WriteLine("how you can do that:");
            string userInput = Console.ReadLine();

            // Loop through the array and append the user's input to each string
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] += userInput;
            }

            // Loop through the array again and print each string
            foreach (string str in myArray)
            {
                Console.WriteLine(str);
            }

            // Wait for user input before closing the console
            Console.ReadLine();
        }
    }
}

