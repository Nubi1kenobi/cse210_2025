using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using Microsoft.Win32.SafeHandles;

public class Scripture
{
    private string _scripture;
    private string _completeReference;
    List<Word> _scriptureListWord = new List<Word>();
    public Scripture(string book, string chapter, string beginningVerse, string scripture)
    {
        string _chapter = chapter;
        string _book = book;
        string _beginningVerse = beginningVerse;
        string _scripture = scripture;
        Reference newReference = new Reference(_book, _chapter, _beginningVerse);
        _completeReference = newReference.GetReference();
    }
    public Scripture(string book, string chapter, string beginningVerse, string endingVerse, string scripture)
    {
        string _book = book;
        string _chapter = chapter;
        string _beginningVerse = beginningVerse;
        string _endingVerse = endingVerse;
        string _scripture = scripture;
        Reference newReference = new Reference(_book, _chapter, _beginningVerse, _endingVerse);
        _completeReference = newReference.GetReference();
    }
    public string GetReference() 
    {
        return _completeReference;}

    public int GetScriptureWordCount()
    {
        int _wordCounter = _scriptureListWord.Count();
        return _wordCounter;
    }
    public int GetHiddenWordsCount()
    {
        int _flaggedWordListCount = 0;
        foreach (Word word in _scriptureListWord)
        {
            if (word.GetStatus()) {_flaggedWordListCount = _flaggedWordListCount +1;}
        }
        return _flaggedWordListCount;
    }
    public void InitializeScripture(string scripture)
    {
        List<string> _scriptureListString = new List<string>();
        _scripture = scripture;
        _scriptureListString = scripture.Split(" ").ToList();
        foreach (string word in _scriptureListString)
        {
            Word wordWord = new Word(word);
            _scriptureListWord.Add(wordWord);
        }
    }

    public string GetUpdatedScripture(string scripture)
    {
        List<string> _scriptureList = new List<string>();
        HideWords();  
        foreach (Word word in _scriptureListWord)
        {
            string cheese = word.GetWord();
            if (word.GetStatus()) {cheese = "".PadLeft(cheese.Length, '_');} 
            _scriptureList.Add(cheese);
        }
        string _scriptureLocal = string.Join(" ", _scriptureList);
        return _scriptureLocal;
    }
    public void GetHiddenWordList()
    {
        int i = 0;
        StringEater youAreACheater1 = new StringEater("\nHere is your Hidden Word List:\n",true);
        foreach (Word word in _scriptureListWord)
        {
            string cheese = $"{word.GetWord()} ({i+1}) | ";
            if (word.GetStatus()) {StringEater youAreACheater2 = new StringEater(cheese,true);}
            i++;
        }
    }
    private void HideWords()
    {
        int _randoCommando = 0;
        int _randomNumberBetween1And3 = Math.Min(Randomizer.RandomInt(3), _scriptureListWord.Count()); 
        if (GetScriptureWordCount() - GetHiddenWordsCount() <= 3) {_randomNumberBetween1And3 = 1;}
        if (GetScriptureWordCount() - GetHiddenWordsCount() > 0) 
        {     
            for (int i = 0; i < _randomNumberBetween1And3; i++)
            {
                if (GetScriptureWordCount()-GetHiddenWordsCount() <= 0) {break;}
                    do 
                    {
                        if (GetScriptureWordCount()-GetHiddenWordsCount() <= 0) {break;}
                        _randoCommando = Randomizer.RandomInt(_scriptureListWord.Count());
                        //Random _random = new Random();
                        //_randoCommando = _random.Next(1,_scriptureListWord.Count());
                    }
                    while (_scriptureListWord[_randoCommando].GetStatus());
                    _scriptureListWord[_randoCommando].SetHide();
            }
        }
    }
        
 
}