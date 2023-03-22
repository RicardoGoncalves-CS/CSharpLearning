using EF_ModelFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_ModelFirst
{
    internal class MenuManager
    {
        public static void MainMenu()
        {
            string input = string.Empty;

            List<string> validMainMenuInput = new List<string>() { "1", "2", "3", "4", "Q", "q" };

            while (!validMainMenuInput.Contains(input))
            {
                Console.WriteLine(">>> Main Menu");
                Console.WriteLine(">>> Enter the number corresponding to the operation to perfom:");
                Console.WriteLine(">>>");
                Console.WriteLine(">>> 1 - List all customers");
                Console.WriteLine(">>> 2 - Add a new customer");
                Console.WriteLine(">>> 3 - Update a customer");
                Console.WriteLine(">>> 4 - Delete a customer");
                Console.WriteLine(">>> Q - Quit");
                Console.Write(">>> ");
                input = Console.ReadLine();
                if (!validMainMenuInput.Contains(input)) Console.WriteLine("Invalid input");
            }
            
            if (input.ToLower() == "q") return;

            switch (input)
            {
                case "1":
                    Console.WriteLine();
                    DbOperations.List();
                    Console.WriteLine();
                    MainMenu();
                    break;
                case "2":
                    Console.WriteLine();
                    AddMenu();
                    Console.WriteLine();
                    MainMenu();
                    break;
                case "3":
                    Console.WriteLine();
                    UpdateMenu();
                    Console.WriteLine();
                    MainMenu();
                    break;
                case "4":
                    Console.WriteLine();
                    DeleteMenu();
                    Console.WriteLine();
                    MainMenu();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                    MainMenu();
                    break;
            }   
        }

        public static void AddMenu()
        {
            Console.WriteLine(">>> Adding new user");
            Console.WriteLine(">>> ");
            DbOperations.Add();
        }

        public static void UpdateMenu()
        {
            Console.WriteLine(">>> Updating user");
            Console.WriteLine(">>> Leave fields that doesn't need updating empty");
            Console.WriteLine(">>> Enter empty ID to return to Main Menu");
            Console.WriteLine(">>> ");
            Console.Write(">>> Enter ID of user to update: ");
            string id = Console.ReadLine();
            if (id == string.Empty) return;
            DbOperations.Update(id);
        }

        public static void DeleteMenu()
        {
            Console.WriteLine(">>> Deleting user");
            Console.WriteLine(">>> Enter empty ID to return to Main Menu");
            Console.WriteLine(">>>");
            Console.Write(">>> Enter ID of user to delete: ");
            string id = Console.ReadLine();
            if (id == string.Empty) return;
            DbOperations.Delete(id);
        }
    }
}
