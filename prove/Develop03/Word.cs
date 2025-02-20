using System;
using System.Dynamic;
public class Word
{
    private bool _isHidden = false;
    private string _theWord = "";
    public Word(string word)
    {
        _theWord = word;
    }
    public void SetHide()
    {
        _isHidden = true;
    }
    public string GetWord()
    {
        return _theWord; 
    }
    public bool GetStatus()
    {
        return _isHidden;
    }
}