using System;
using System.ComponentModel.Design;
class CountTo10
{
    private int _low;
    private int _high;
    private bool _countDown;
    private bool _randomLanguage;
    private int _randomLanguageInt;
    private List<string> _randomLanguageList = new List<string>(){};
    private List<string> _english = new List<string>(){"one","two","three","four","five","six","seven","eight","nine","ten"};
    private List<string> _japanese = new List<string>(){"ichi","ni","san","shi","go","roku","shichi","hachi","kyuu","juu"};
    private List<string> _spanish = new List<string>(){"uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez"};
    private List<string> _french = new List<string>(){"un","deux","tois","quatre","cinq","six","sept","huit","Neuf","dix"};
    private List<string> _chinese = new List<string>(){"yī","èr","sān","sì","wǔ","liù","qī","bā","jiǔ","shí"};
    private List<string> _arabic = new List<string>(){"wahid","ethnein","thalatha","arba'a","khamsa","sitta","sab'a","tamaniya","tis-a","ashara"};
    private List<string> _russian = new List<string>(){"odin","dva","tri","chetyre","pyat","shest","sem","vosem","deviat","desiat"};
    private List<string> _german = new List<string>(){"eins","zwei","drei","vier","fünf","sechs","sieben","acht","neun","zehn"};
    private List<string> _hebrew = new List<string>(){"echad","shnayim","shlosha","arba","chamisha","shisha","shiv'a","shmona","tisha","asara"};
    private List<string> _binary = new List<string>(){"0000","0001","0100","0101","0110","0111","1000","1001","1010"};
    public void CountUp(int low, int high)
    {
        if (low <1) {_low = 1;}
        if (high > 10) {_high = 10;} 
        RandomLangCase(RandomizeLaguages()); 
        {
            for (int i = low; i < high; i++) 
            {
                StringEater mySacrafice1 = new StringEater($"({i}.) {_randomLanguageList[i-1]} ", 0, true); 
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");
        }
        
    }
    public void CountDown(int low, int high)
    {
        if (low <1) {_low = 1;}
        if (high > 10) {_high = 10;} 
        RandomLangCase(RandomizeLaguages()); 
        {
            for (int i = high; i > low; i--) 
            {
                StringEater mySacrafice2 = new StringEater($"({i}.) {_randomLanguageList[i-1]} ", 0, true); 
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");
        }
        
    }
        public void CountDownInPlace(int low, int high)
    {
        if (low < 1) {_low = 1;}
        if (high > 10) {_high = 10;} 
        RandomLangCase(RandomizeLaguages()); 
        {
            for (int i = high; i > low; i--) 
            {
                //StringEater mySacrafice2 = new StringEater($"({i}.) {_randomLanguageList[i-1]} ", 0, true); 
                StringEater mySacrafice2 = new StringEater($"{_randomLanguageList[i-1]} ", 0, true); 
                Thread.Sleep(1000);
                foreach (char c in _randomLanguageList[i-1]){Console.Write("\b");}
                Console.Write("\b");
                foreach (char c in _randomLanguageList[i-1]) {Console.Write(" ");}
                foreach (char c in _randomLanguageList[i-1]){Console.Write("\b");}
            }
        }
    }
    private int RandomizeLaguages() {return Randomizer.RandomInt(10);}
    private void RandomLangCase(int parameter)
    {
        switch (parameter)
        {
            case 1:
                _randomLanguageList = _english;
                return;
            case 2:
                _randomLanguageList = _japanese;
                return;
            case 3:
                _randomLanguageList = _spanish;
                return;
            case 4:
                _randomLanguageList = _french;
                return;
            case 5:
                _randomLanguageList = _chinese;
                return;
            case 6:
                _randomLanguageList = _arabic;
                return;
            case 7:
                _randomLanguageList = _russian;
                return;
            case 8:
                _randomLanguageList = _german;
                return;
            case 9:
                _randomLanguageList = _hebrew;
                return;
            case 10:
                _randomLanguageList = _binary;
                return;

            default:
                return;
        }
    }    
} 
