using System;

namespace TestApp {
    class Start {
        static void Main(string[] args) {
            string welcomeText = System.IO.File.ReadAllText(@"./welcome.txt");

            Console.WriteLine(welcomeText);

            while(true) {
                string command = Console.ReadLine();
                try {
                    if (Int32.Parse(command) == 0)
                    {
                        break;
                    }
                } catch (System.FormatException e)
                {
                    Console.WriteLine("Please enter 0 to exit: ");
                } finally
                {
                    Console.WriteLine("Please enter 0 to exit: ");
                }
            }
            Console.WriteLine("Exiting");
        }
    }
}