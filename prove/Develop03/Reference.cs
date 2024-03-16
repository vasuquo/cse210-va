public class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        string verses = $"{_verse}";
        if (_endVerse.Length > 0)
        {
            verses = $"{_verse}-{_endVerse}";
        }
        return $"{_book}{_chapter}:{verses}";
    }
}