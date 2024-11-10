public class Activity
{
    protected string _startMessage;
    protected string _endMessage;
    protected string _description;
    protected int _duration;

    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }
    public string GetStartMessage()
    {
        return _startMessage;
    }
    public void SetEndMessage(string endMessage)
    {
        _endMessage = endMessage;
    }
    public string GetEndMessage()
    {
        return _endMessage;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void Animation()
    {
        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write(">");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("<");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write(">");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b");

        Console.Write("<");
    }
}