using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use a variable to store your greeting
            var greeting = "Welcome to AC!";
            Console.WriteLine(greeting);

            //Output a string literal
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hi {0} !", name);

        }
    }
}
