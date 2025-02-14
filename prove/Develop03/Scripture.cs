using System;
using System.Net;
using System.Runtime.CompilerServices;
public class Scripture
{
    private string _scripture;
    private string[] _scriptureWords;
    List<bool> _hiddenFlagList = new List<bool>();

    
    public Scripture(string book, string chapter, string beginningVerse, string scripture)
    {
        string _chapter = chapter;
        string _book = book;
        string _beginningVerse = beginningVerse;
        string _scripture = scripture;
        Reference newReference = new Reference(_book, _chapter, _beginningVerse);
    }
    public Scripture(string book, string chapter, string beginningVerse, string endingVerse, string scripture)
    {
        string _book = book;
        string _chapter = chapter;
        string _beginningVerse = beginningVerse;
        string _endingVerse = endingVerse;
        Reference newReference = new Reference(_book, _chapter, _beginningVerse, _endingVerse);
    }
    public int GetScriptureWords()
    {
        return _scriptureWords.Count();
    }

    public string GetSripture(string scripture)
    {
        _scripture = scripture;
         int ii = 0;       
        _scriptureWords = _scripture.Split(' ');
        Console.WriteLine(_scriptureWords.Length);        
        foreach (string singleWord in _scriptureWords)
        {            
            Console.Write(singleWord);
            //Word newWord = new Word(false);
            ii++;
            if (ii == singleWord.Length) {Console.Write("");}
            else {Console.Write(" ");}
        }
        ii = 0;

        return _scripture;
    }

        
 
}