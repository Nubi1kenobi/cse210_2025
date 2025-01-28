using System;

class Program
{
    static void Main(string[] args)
    {
        string menu = "-1";
        Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
        Console.Clear();

        while (menu != "I QUIT")
        {
            Console.Clear();
            string userInput = Journal.JournalMenu();
            menu = Journal.JournalMenuChoice(userInput);
            Console.WriteLine(Journal.)
            Journal.PressAnyKey();
        }
        Console.Clear();
        Console.WriteLine("Goodbye, Au revoir, Auf Wiedersehen, Yasou, L'hitraot, Namaste, Viszlát!, Vertu Saeill!, Atsiprasau, Zài jiàn, Namaste, Ha det bra, Khodaa haafez, Żegnaj, Adeus , Adiós, Chao, Dasvidaniya, Poka, Bài bài, Zàijiàn, Arrivederci, Ciao, Sayonara, Ja nee, Farvel, Kwaheri, Baadaye");
    }
}