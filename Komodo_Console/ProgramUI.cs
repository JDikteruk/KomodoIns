using Komodo_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Console
{
    class ProgramUI
    {
        public void Run()
        {
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a Menu Option:\n" +
                    "1. Create Developer\n" +
                    "2. View All Developers\n" +
                    "3. Update Developer\n" +
                    "4. Delete Developer\n" +
                    "5. Create Development Team\n" +
                    "6. View Development Teams\n" +
                    "7. Update Development Team\n" +
                    "8. Delete Development Team\n" +
                    "9. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateDeveloper();
                        break;
                    case "2":
                        ViewDevelopers();
                        break;
                    case "3":
                        UpdateDeveloper();
                        break;
                    case "4":
                        DeleteDeveloper();
                        break;
                    case "5":
                        CreateDevTeam();
                        break;
                    case "6":
                        ViewDevTeam();
                        break;
                    case "7":
                        UpdateDevTeam();
                        break;
                    case "8":
                        DeleteDevTeam();
                        break;
                    case "9":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateDeveloper()
        {
            Developer developer = new Developer();
        }

        private void ViewDevelopers()
        {

        }
        
        private void UpdateDeveloper()
        {

        }
        
        private void DeleteDeveloper()
        {

        }

        private void CreateDevTeam()
        {

        }
            
        private void ViewDevTeam()
        {

        }

        private void UpdateDevTeam()
        {

        }
            
        private void DeleteDevTeam()
        {

        }
        
    }
}
