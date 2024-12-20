using System.Reflection;

public class Reflection : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."  
    };
    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void RunReflection()
    {
        SetStartMessage("Welcome to the Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resiliance. This will help you Recognize the power you have and how you can use it in other aspects of your life.");
        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(int.Parse(Console.ReadLine()));
        int duration = GetDuration();
        SetEndMessage("Well done!! \n \n You have completed another" + duration + "seconds of the Reflecting ACtivity.");
    }
    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    public string RandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        return prompts[index];
    }
}