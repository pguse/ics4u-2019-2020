using System;
using System.IO;

namespace ProvincesQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileContents; // each element is a line from the file
            string[] question;     // will contain two elements - province and captial

            Console.WriteLine("Welcome to the Provinces Quiz!");
            Console.WriteLine();

            // Read each line from the CSV file as a string, store array element
            fileContents = File.ReadAllLines("provinces.csv");

            // Output the fileContents array elements
            for(var i=0; i < fileContents.Length; i++){
                Console.WriteLine(fileContents[i]);
            }
            Console.WriteLine();
            
            // Parse the first line of the file

            // split element into question and answer
            question = fileContents[0].Split(',');
            // output province
            Console.WriteLine(question[0]);
            // output answer
            Console.WriteLine(question[1]);

            // The lines above are meant to demonstrate
            // how to read in data from a file - each
            // line stored as a string in an array - and
            // how to split a string into an array - using
            // a comma as the separator

            // Your Task
            // Create a simple quiz game that randomly selects
            // a province and then asks the user for the capital.
            // Ask five questions, and keep track of the number
            // of correct answers.  Output the score at the end
            // of the quiz.

        }
    }
}
