using System.Net.Mail;

public class Journal
{
    public string _filename = "";
    public List<string> entries = new List<string>();

    public Journal(){}
    public void NewEntry()
    {
        Entry entry = new Entry();
        entry.NewEntry();
    }
    public void DisplayEntries()
    {
        foreach (string entry in entries)
        {
            Entry entry1 = new Entry();
            entry1.DisplayEntry();
        }
    }


    public void Load(string filename)
    {
        _filename = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
        }
    }


    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}