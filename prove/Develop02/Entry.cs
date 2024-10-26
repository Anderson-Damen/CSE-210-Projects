public class Entry
{
    public string _response = "";
    public string _randomPrompt = "";
    public string _date = "";
    public Entry()
    {}
    public string NewEntry(string entry)
    {
        _date = DateTime.Now.ToString("MM/dd/yyyy");
        RandomPromptGenerator prompt = new RandomPromptGenerator();
        _randomPrompt = prompt.RandomPrompt();
        Console.WriteLine(_randomPrompt);
        Console.Write("> ");
        _response = Console.ReadLine();
        entry = _date + ";" + _randomPrompt + ";" + _response + ";";
        return entry;
    }
    public void DisplayEntry()
    {
        Console.WriteLine("Date: " + _date +";" + " Prompt: " + _randomPrompt + ";");
        Console.WriteLine("Response: " + _response);
    }

}