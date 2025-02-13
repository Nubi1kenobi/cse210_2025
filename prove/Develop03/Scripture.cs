using System;
using System.Net;
using System.Runtime.CompilerServices;
public class Scripture
{
    private string _scripture;
    private string[] _scriptureWords;
    private bool _flag = false;

    
    public Scripture(string book, string chapter, string beginningVerse, string scripture)
    {
        string _chapter = chapter;
        string _book = book;
        string _beginningVerse = beginningVerse;
        string _scripture = scripture;
        //int ii = 0;
  
        
        Reference newReference = new Reference(_book, _chapter, _beginningVerse);
        _scriptureWords = _scripture.Split(' ');
        Console.WriteLine(_scriptureWords.Length);
        
        
    //    foreach (string a in _scriptureWords)
      //  {            
            //Console.Write($"{a[ii]}");
    
        //}
       // ii = 0;

    }
    public Scripture(string book, string chapter, string beginningVerse, string endingVerse, string scripture)
    {
        string _book = book;
        string _chapter = chapter;
        string _beginningVerse = beginningVerse;
        string _endingVerse = endingVerse;
        //nt ii = 0;

        Reference newReference = new Reference(_book, _chapter, _beginningVerse, _endingVerse);
        _scriptureWords = _scripture.Split(' ');
        Console.WriteLine(_scriptureWords.Length);
        
        
    //    foreach (string a in _scriptureWords)
      //  {            
            //Console.Write($"{a[ii]}");
    
        //}
       // ii = 0;
        }
    }