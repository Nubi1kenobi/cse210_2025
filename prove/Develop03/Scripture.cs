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
    List<bool> _hiddenFlagList = new List<bool>();
    List<string> _scriptureList = new List<string>();
    List<string> _scriptureListBase = new List<string>();
    List<string> _hiddenWordList = new List<string>();
    List<Word> _flagList = new List<Word>();  
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
        int _wordCounter = _scriptureList.Count();
        return _wordCounter;
    }
    public int GetHiddenWordsCount()
    {
        int _flaggedWordListCount = 0;
        foreach (Word _w in _flagList)
        {
            if (_w.GetStatus()) {_flaggedWordListCount = _flaggedWordListCount +1;}
        }
        return _flaggedWordListCount;
    }

    public string GetScripture(string scripture)
    {
        _scripture = scripture;
        _scriptureList = scripture.Split(" ").ToList();
        _scriptureListBase = scripture.Split(" ").ToList();
        foreach (string _a in _scriptureList) 
        {
            Word newWord = new Word();
            _flagList.Add(newWord);
        }
        return _scripture;
    }
    public string GetUpdatedScripture(string scripture)
    {
        _scripture = scripture;
        _scriptureList = scripture.Split(" ").ToList();
        
        HideWords();  
        int _i = 0;
        string _wordToHide = "";
        foreach (Word _w in _flagList)
            { 
                if (_w.GetStatus())
                {
                    _wordToHide = _scriptureListBase[_i];
                    _hiddenWordList.Add($"{_wordToHide}|{_i}");  //fix the concat!
                    _scriptureList[_i] = "".PadLeft(_scriptureList[_i].Length, '_');
                };
                _i++;
            }     
        //_scripture = "";
        _scripture = string.Join(" ", _scriptureList);
        return _scripture;
    }
    public void GetHiddenWordList()
    {
        int _ii = 0;
        Console.WriteLine("Here is your Hidden Word List:");
        foreach (Word _w in _flagList)
        {
            if (_w.GetStatus()) {Console.WriteLine(_scriptureListBase[_ii]);}
            _ii++;
        }
    }
    private void HideWords()
    {
        int _randoCommando = 0;
        int _randomNumberBetween1And3 = Math.Min(Randomizer.RandomInt(3), _scriptureList.Count()); 
       for (int _i = 0; _i < _randomNumberBetween1And3; _i++)
       {
            do 
            {
                _randoCommando = Randomizer.RandomInt(_scriptureList.Count());
            }
            while (_flagList[_randoCommando].GetStatus());
            _flagList[_randoCommando].SetHide();
       }
    }
    private int WordRandomizer()
    {
        int _randomNumber = Randomizer.RandomInt(_scriptureList.Count());
        return _randomNumber;
    }
        
 
}