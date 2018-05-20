using System;

namespace LinqDemo
{
    class Program
    {
        private static void OutputEmployeInfo()
        {
            //TODO output count of employes in database

            throw new NotImplementedException();
        }

        private static void OutputCountOfManagers()
        {
            //TODO output count of managers

            throw new NotImplementedException();
        }

        private static void OutputCountOfEmployes()
        {
            /*TODO 
             * 1. read employe ID
             * 2. find employe in DB
             * 3. output employe information, if employe has manager output managers Name
             */

            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1: Get count of employes in database.");
            Console.WriteLine("2. Get count of managers in database.");
            Console.WriteLine("3. Get employe information.");

            var userInput = Console.ReadLine();
            int userChoice;
            var parseResult = int.TryParse(userInput, out userChoice);

            if (!parseResult)
            {
                Console.WriteLine("WRONG INPUT");
                Menu();
                return;
            }

            switch (userChoice)
            {
                case 1:
                    OutputCountOfEmployes();
                    break;
                case 2:
                    OutputCountOfManagers();
                    break;
                case 3:
                    OutputEmployeInfo();
                    break;
                default:
                    Console.WriteLine("WRONG INPUT");
                    Menu();
                    return;
            }
        }
    }
}
