using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

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
                Journal journal = new Journal();
                journal.NewEntry(); 
            }

            //Display entries
            else if (choice == "2")
            {
                Journal journal = new Journal();
                journal.DisplayEntries();

            }

            //Load file
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                Journal journal = new Journal();
                journal.Load(filename);            
            }

            //Save file
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                Journal journal = new Journal();
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