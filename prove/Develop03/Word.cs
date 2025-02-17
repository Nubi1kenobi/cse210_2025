using System;
using System.Dynamic;
public class Word
{
    private bool _isHidden = false;
    public void SetHide()
    {
        _isHidden = true;
    }
    public bool GetStatus()
    {
        return _isHidden;
    }
}