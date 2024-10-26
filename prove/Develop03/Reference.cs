public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private bool _hasEnded = false;
    public Reference(string book, string chapter, string verse){}

    public void DisplayReference()
    {
        Scripture scripture = new Scripture();
        scripture.Add
        Console.Clear();
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }


}