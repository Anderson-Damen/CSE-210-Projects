using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            choice = Console.ReadLine();
            

            //Write new entry
            if (choice == "1")
            {
                journal.NewEntry(); 
            }

            //Display entries
            else if (choice == "2")
            {
                journal.DisplayEntries();

            }

            //Load file
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.Load(filename);            
            }

            //Save file
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }

            //Quit program
            else if (choice == "5")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }


    }
}