using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";

        if (grade >= 94)
        {
            letter = "A";
        }
        else if (grade >= 90)
        {
            letter = "A-";
        }
        else if (grade >= 87)
        {
            letter = "B+";
        }
        else if (grade >= 84)
        {
            letter = "B";
        }
        else if (grade >= 80)
        {
            letter = "B-";
        }
        else if (grade >= 77)
        {
            letter = "C+";
        }
        else if (grade >= 74)
        {
            letter = "C";
        }
        else if (grade >= 70)
        {
            letter = "C-";
        }
        else if (grade >= 67)
        {
            letter = "D+";
        }
        else if (grade >= 64)
        {
            letter = "D";
        }
        else if (grade >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.");
        }
        Console.WriteLine($"Your grade is: {letter}");
    }
}