public class Entry
{
    public string _response = "";
    public string _randomPrompt = "";
    public string _date = "";
    public Entry()
    {}
    public void NewEntry()
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        RandomPromptGenerator prompt = new RandomPromptGenerator();
        _randomPrompt = prompt.RandomPrompt();
        Console.WriteLine(_randomPrompt);
        Console.Write("> ");
        _response = Console.ReadLine();
    }
    public void DisplayEntry()
    {
        Console.WriteLine("Date: " + _date +";" + " Prompt: " + _randomPrompt + ";");
        Console.WriteLine("Response: " + _response);
    }

}