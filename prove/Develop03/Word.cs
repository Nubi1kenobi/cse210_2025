using System;
public class Word
{
    private bool _isHidden = false;
    public Word(bool isHidden)
    {
        _isHidden = isHidden;
    }
    public bool GetStatus()
    {
        return _isHidden;
    }
}