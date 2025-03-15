public class Menu
{
        public Menu(params string[] options)
    {
        for (int i = 0; i < options.Length; i++)
        {
            StringEater menu0 = new StringEater($"{i + 1}. {options[i]}\n", 10, true);
        }
    }
    public Menu(int score, params string[] options)
    {
        for (int i = 0; i < options.Length; i++)
        {
            StringEater menu0 = new StringEater($"{i + 1}. {options[i]}\n", 10, true);
        }
        
        StringEater menu1 = new StringEater($"0. Quit\n\n", 10, true);
        StringEater menu2 = new StringEater($"Current Score: {score}\n", 10, true);
    
    }
}