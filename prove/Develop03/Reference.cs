using System;
public class Reference
{
    private string _book;
    private string _chapter;
    private string _beginningVerse;
    private string _endingVerse;    

    public Reference(string book, string chapter, string beginningVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginningVerse = beginningVerse;
    }
    public Reference(string book, string chapter, string beginningVerse, string endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginningVerse = beginningVerse;
        _endingVerse = endingVerse;
    }
    public string GetReference()
    {
        string scriptureReference = "";
        if (_endingVerse == "") 
        {
            scriptureReference = $"{_book} {_chapter}:{_beginningVerse}";
        }
        else if (_endingVerse != "") 
        {
            scriptureReference = $"{_book} {_chapter}:{_beginningVerse}-{_endingVerse}";
        }
        return scriptureReference;

    }
}