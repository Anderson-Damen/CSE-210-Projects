using System;
public class Journal
{
    public string _filename = "";
    public string _newEntry = "";
    public List<string> entries = new List<string>();
    

    public Journal(){}
    public void NewEntry()
    {
        Entry entry = new Entry();
        _newEntry = entry.NewEntry(_newEntry);
        entries.Add(_newEntry);
    }
    public void DisplayEntries()
    {
        foreach (string ent in entries)
        {
            Entry entry = new Entry();
            entry.DisplayEntry();
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