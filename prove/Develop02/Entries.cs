public class Entry{
    public string _date = Convert.ToString(DateTime.Now);
    

    public string _prompt;
    public string _entry;

    public Entry(string prompt, string entry)
    {
        _prompt = prompt;

        _entry = entry;
    }
    
    public void WriteNewEntry()
    {
        _entry = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine( $"{_entry}");
    }


}