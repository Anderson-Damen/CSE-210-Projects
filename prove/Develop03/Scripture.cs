public class Scripture
{
    private string _text;
    List<Word> _words = new List<Word>();

    public Scripture(string reference, string text)
    {
        _text = text;
        string[] words = _text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetText()
    {
        return _text;
    }
    
}