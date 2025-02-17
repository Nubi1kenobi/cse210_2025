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
    List<Word> _flagList = new List<Word>();
    

    

    
    public Scripture(string book, string chapter, string beginningVerse, string scripture)
    {
        string _chapter = chapter;
        string _book = book;
        string _beginningVerse = beginningVerse;
        string _scripture = scripture;
        Reference newReference = new Reference(_book, _chapter, _beginningVerse);
        _completeReference = newReference.GetReference();
        //Utility.Debug($"Scripture ConstructorA: {_completeReference}");
        //Utility.Debug($"Scripture ConstructorA: {_scripture}");
    }
    public Scripture(string book, string chapter, string beginningVerse, string endingVerse, string scripture)
    {
        string _book = book;
        string _chapter = chapter;
        string _beginningVerse = beginningVerse;
        string _endingVerse = endingVerse;
        Reference newReference = new Reference(_book, _chapter, _beginningVerse, _endingVerse);
        _completeReference = newReference.GetReference();
        //Utility.Debug($"Scripture ConstructorB: {_scripture}");
    }
    public string GetReference() 
    {
        //Utility.Debug($"Scripture.GetReference(): {_completeReference}");
        return _completeReference;}

    public int GetScriptureWordCount()
    {
        int _wordCounter = _scriptureList.Count();
        //Utility.Debug($"GetScriptureWordCount: {_wordCounter}");
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
        foreach (string _a in _scriptureList) 
        {
            Word newWord = new Word();
            _flagList.Add(newWord);
        }
        //Utility.Debug($"GetScripture(string scripture) _flaggedWordListCount: {_flaggedWordListCount}");
        //Utility.Debug($"GetScripture(string scripture) _flagList should be fully populated: {_flagList.Count()}");
        return _scripture;
    }
    public string GetUpdatedScripture(string scripture)
    {
        _scripture = scripture;
        _scriptureList = scripture.Split(" ").ToList();
                foreach (string _a in _scriptureList) 
        {
            Word newWord = new Word();
            _flagList.Add(newWord);
        }
        int _i = 0;
        //Utility.Debug($"GetUpdatedScripture(string scripture) - _scriptureList.Count(): {_scriptureList.Count()}");
        //Utility.Debug($"GetUpdatedScripture(string scripture) - _flaggedWordListCount: {_flaggedWordListCount}");
        //_flagList[5].SetHide();
        foreach (Word _w in _flagList)
            { 
                if (_w.GetStatus())
                {
                     _scriptureList[_i] = "".PadLeft(_scriptureList[_i].Length, '_');
                     //Console.Write($"{_scriptureList[_i]}  "); 
                };
                _i++;
            }    
        //Console.Clear();
        //foreach (string s in _scriptureList) {Console.Write($"{s} ");}
        //Utility.PressAnyKey();

        //Utility.Debug("GetUpdatedScripture(string scripture): About to Hide Wordes");
        HideWords();    
        _scripture = "";
        _scripture = string.Join(" ", _scriptureList);
        return _scripture;
    }

    private void HideWords()
    {
        int _randoCommando = 0;
        int _randomNumberBetween1And3 = Math.Min(Randomizer.RandomInt(3), _scriptureList.Count()); 
        //Utility.Debug($"Get UpdatedScripture()/HideWords(): _randomNumberBetween1And3: {_randomNumberBetween1And3}");   
       for (int _i = 0; _i < _randomNumberBetween1And3; _i++)
       {
            do 
            {
                _randoCommando = Randomizer.RandomInt(_scriptureList.Count());
                //Utility.Debug(_flagList[_randoCommando].GetStatus());
            }
            while (_flagList[_randoCommando].GetStatus());
            //Utility.Debug(_flagList[_randoCommando].GetStatus());
            _flagList[_randoCommando].SetHide();
       }

    }
    private int WordRandomizer()
    {
        int _randomNumber = Randomizer.RandomInt(_scriptureList.Count());
        return _randomNumber;
    }
        
 
}