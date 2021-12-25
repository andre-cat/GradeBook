using System;

// # Hola, soy Andrea Arias. :D

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"{args[0]}, eres una mala persona. >:v");
            }
            else
            {
                Console.WriteLine("Eres una mala persona. v:<");
            }
        }
    }
}