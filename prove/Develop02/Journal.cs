public class Journal
{
    //List of prompts
    public List<string> _promptList = new List<string>();

    public Journal()
        {

            _promptList.Add("What was the weather like today?");
            _promptList.Add("What was the most memorable thing that happened to you today?");
            _promptList.Add("If you could change something about today, what would it be?");
            _promptList.Add("How did you see the hand of the Lord in your life today?");
            _promptList.Add("Who did you interact with today?");
            
        }

    //List of entries
    public List<Entry> _entriesList = new List<Entry>();

    //File name
    public string _filePath;

    //Generates random prompt from prompt list
    public string RandomPrompt()
           {
            Random rd = new Random();
                int rand_num = rd.Next(0,4);

            return $"{_promptList[rand_num]}";
        
           }

    //Displays entries within the entry list    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entriesList)
        {
            entry.DisplayEntry();
        }
    }

    //Saves entries from entry list to a txt file
    public void SaveToFile(List<Entry> _entriesList)
    {
        Console.Write("(Enter the file name): ");
        _filePath = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter (_filePath))
        {
            foreach (Entry entry in _entriesList)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entry}");
                // outputFile.WriteLine(entry._prompt);
                // outputFile.WriteLine(entry._entry);
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("(Enter the file name): ");
        _filePath = Console.ReadLine();


        string[] lines = System.IO.File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
            //string[] parts = line.Split("~~");
            //_date = parts[0];
            //_prompt = parts[1];
            //_entry = parts[2];
        }
    }

        
}