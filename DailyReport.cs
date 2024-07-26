using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the header
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            // Ask for the student's name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // Ask for the course name
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            // Ask for the page number
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());

            // Ask if the student needs help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);

            // Ask for positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Ask for any other feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Ask for the number of study hours
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);

            // Print the thank you message
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
