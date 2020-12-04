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
        private DeveloperRepo _devRepo = new DeveloperRepo();
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
        public void Run()
        {
            SeedDeveloper();
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
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void CreateDeveloper()
        {
            Console.Clear();

            Developer developer = new Developer();

            // Name
            Console.WriteLine("Enter Developer Name");
            developer.Name = Console.ReadLine();

            // ID
            Console.WriteLine("Enter Developer ID");
            string idAsString = Console.ReadLine();
            developer.ID = int.Parse(idAsString);

            // accessPluralsight
            Console.WriteLine("Enter Developer Pluralsight Access Granted(Y/N)");
            string accessGranted = Console.ReadLine().ToUpper();
            
            if(accessGranted == "Y")
            {
                developer.AccessPluralsight = true;
            }
            else
            {
                developer.AccessPluralsight = false;
            }

            _devRepo.AddDeveloper(developer);
        }

        private void ViewDevelopers()
        {
            Console.Clear();

            List<DeveloperRepo> developerList = _devRepo.GetDeveloperList();

            foreach (Developer developer in developerList)
            {
                Console.WriteLine($"Name: {developer.Name}\n" +
                    $"Developer ID: {developer.ID}\n" +
                    $"Has access to Pluralsight: {developer.AccessPluralsight}")
            }
        }
        
        private void UpdateDeveloper()
        {
            Console.Clear();
        }
        
        private void DeleteDeveloper()
        {
            Console.Clear();
        }

        private void CreateDevTeam()
        {
            Console.Clear();
            /*
             * TeamName
             * TeamID
             * TeamMember
             */*
        }
            
        private void ViewDevTeam()
        {
            Console.Clear();
        }

        private void UpdateDevTeam()
        {
            Console.Clear();
        }
            
        private void DeleteDevTeam()
        {
            Console.Clear();
        }
        

        private void SeedDeveloper()
        {
            Developer jon = new Developer("Jonathan Dikteruk", 1000001, false);
            Developer thor = new Developer("Thor Dikteruk", 1000002, false);
            Developer optimus = new Developer("Optimus Prime", 1000003, true);
            Developer iron = new Developer("Iron Hide", 1000004, true);
            Developer megs = new Developer("Mega Tron", 1000005, true);
            Developer star = new Developer("Star Scream", 1000006, true);

            _devRepo.AddDeveloper(jon);
            _devRepo.AddDeveloper(thor);
            _devRepo.AddDeveloper(optimus);
            _devRepo.AddDeveloper(iron);
            _devRepo.AddDeveloper(megs);
            _devRepo.AddDeveloper(star);

        }
    }
}
