using System;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            cc.WelcomeAction();
            while (true)
            {
                Console.WriteLine("Would you like to learn about another country? y/n");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine();
                    cc.SecondAction();
                }
                if(answer == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
