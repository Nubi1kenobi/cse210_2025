using System;
using System.ComponentModel.Design;
class CountTo10
{
    int _low;
    int _high;
    bool _countDown;
    bool randomLanguage;
    List<string> english = new List<string>(){"one","two","three","for","five","six","seven","eight","nine","ten"};
    List<string> japanese = new List<string>(){"ichi","ni","san","shi","go","roku","shichi","hachi","kyuu","juu"};
    List<string> spanish = new List<string>(){"uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez"};
    List<string> french = new List<string>(){"un","deux","tois","quatre","cinq","six","sept","huit","Neuf","dix"};
    List<string> chinese = new List<string>(){"yī","èr","sān","sì","wǔ","liù","qī","bā","jiǔ","shí"};
    List<string> arabic = new List<string>(){"wahid","ethnein","thalatha","arba'a","khamsa","sitta","sab'a","tamaniya","tis-a","ashara"};
    List<string> russian = new List<string>(){"odin","dva","tri","chetyre","pyat","shest","sem","vosem","deviat","desiat"};
    List<string> german = new List<string>(){"eins","zwei","drei","vier","fünf","sechs","sieben","acht","neun","zehn"};
    List<string> hebrew = new List<string>(){"echad","shnayim","shlosha","arba","chamisha","shisha","shiv'a","shmona","tisha","asara"};
    List<string> binary = new List<string>(){"0000","0001","0100","0101","0110","0111","1000","1001","1010"};

    public CountTo10(int low, int high, bool countDown, bool randomLanguage) //base constructor
    {
        if (low <1) {_low = 1;}
        if (high > 10) {_high = 10;}
        if (countDown = false) 
        {
            for (int i = low; i < high; i++) {StringEater mySacrafice = new StringEater($"{i}", 10, true); Utility.PressAnyKey();}    
        }
        
    }

    //public void

}