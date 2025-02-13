public class Scripture
{
    HashSet<int> replacedIndices = new HashSet<int>();
    private string _scripture;

     private List<string> _wordsList = new List<string>();

    public string GetScripture()
    {
        return _scripture;
    }

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

     public void SeperateWords(string text)
    {
        // text = Console.ReadLine();
        char[] delimiters = new char[] { ' ', '.', ',', '!', '?', ':' };
        string[] wordsArray = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        _wordsList = wordsArray.ToList();
    }

    public void JoinWords()
    {
        string newSentence = string.Join(" ", _wordsList);

        Console.WriteLine(newSentence);
    }

    public void DeleteRandomWords()
    {
        Random random = new Random();
        int numberOfWordsToReplace = random.Next(0, _wordsList.Count);
        
        while (replacedIndices.Count < numberOfWordsToReplace)
        {
            int index = random.Next(0, _wordsList.Count);
            if (!replacedIndices.Contains(index))
            {
                _wordsList[index] = "---";
                replacedIndices.Add(index);
            }
        }
    }

    public bool EndCondition()
    {
        return replacedIndices.Count == _wordsList.Count;
    }
}
