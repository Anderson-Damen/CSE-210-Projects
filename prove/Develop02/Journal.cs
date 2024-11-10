using System;
public class Journal
{
    public string _filename = "";
    public string _newEntry = "";
    public List<Entry> entries = new List<Entry>();
    

    public Journal(){}
    public void NewEntry()
    {
        Entry entry = new Entry();
        entry.NewEntry();
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry ent in entries)
        {
            ent.DisplayEntry();
        }
    }


    public void Load(string filename)
    {
        _filename = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            Entry LoadEntry = new Entry();

            LoadEntry._date = parts[0];
            LoadEntry._randomPrompt = parts[1];
            LoadEntry._response = parts[2];

            entries.Add(LoadEntry);
        }
    }


    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date}; {entry._randomPrompt}; {entry._response}");
            }
        }
    }
}