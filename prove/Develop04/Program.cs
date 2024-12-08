using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Net.Quic;

class Program
{
   
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. quit");
            Console.Write("Select an option from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Breathing breathing = new Breathing();
                breathing.RunBreathing();
            }
            else if (choice == 2)
            {
                Reflection reflecting = new Reflection();
                reflecting.SetStartMessage("Welcome to the Reflecting Activity");
                reflecting.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you Recognize the power you have and how you can use it in other aspects of your life.");
                Console.Write("How long, in seconds, would you like for your session? ");
                reflecting.SetDuration(int.Parse(Console.ReadLine()));
                int duration = reflecting.GetDuration();
                reflecting.SetEndMessage("Well done!! \n \n You have completed another" + duration + "seconds of the Reflecting ACtivity.");
            }
            else if (choice == 3)
            {
                Listing listing = new Listing();
                listing.SetStartMessage("Welcome to the Listing Activity");
                listing.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.Write("How long, in seconds, would you like for your session? ");
                listing.SetDuration(int.Parse(Console.ReadLine()));
                int duration = listing.GetDuration();
                listing.SetEndMessage("Well done!! \n \n You have completed another" + duration + "seconds of the Listing ACtivity.");
            }
            else if (choice == 4)
            {
                choice = 4;
            }
            else
            {
                break;
            }
        }
    }
}