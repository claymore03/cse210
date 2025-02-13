public class Reference
{
    private int _bookNumber;
    
    private string _book;
    
    private int _chapter;

    private int _startVerse;

    private int _endVerse;

    public Reference()
    {
        _bookNumber = 0;
        
        _book = "";

        _chapter = 0;

        _startVerse = 0;

        _endVerse = 0;
    }
    
    public Reference(string bookName, int chapterNum, int verse1)
    {
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;
    }

    public Reference(string bookName, int chapterNum, int verse1, int verse2)
    {  
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;

        _endVerse = verse2;
    }

    public Reference(int bookNum, string bookName, int chapterNum, int verse1, int verse2)
    {
        _bookNumber = bookNum;
        
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;

        _endVerse = verse2;
    }

    public Reference(int bookNum, string bookName, int chapterNum, int verse1)
    {
        _bookNumber = bookNum;
        
        _book = bookName;

        _chapter = chapterNum;

        _startVerse = verse1;
    }

    //For references such as Helaman 5:12
    public string ReferenceType1()
    {
        string text = $"{_book} {_chapter}:{_startVerse}";
        return text;
    }

    //For references such as 1Nephi 3:7
    public string ReferenceType2()
    {
        string text = $"{_bookNumber}{_book} {_chapter}:{_startVerse}";
        return text;
    }

    //For references such as Alma 5:21-30
    public string ReferenceType3()
    {
        string text = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return text;
    }

    //For references such as 3Nephi 18:1-3
    public string ReferenceType4()
    {
        string text = $"{_bookNumber}{_book} {_chapter}:{_startVerse}-{_endVerse}";
        return text;
    }

}