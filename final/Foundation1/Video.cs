class Video
{
    private string _videoName;

    private string _videoDate;

    private int _videoDuration;

    public string GetVideoName()
    {
        return _videoName;
    }

    public void SetVideoName(string videoName)
    {
       videoName = _videoName;
    }  
    public string GetVideoDate()
    {
        return _videoDate;
    }

    public void SetVideoDate(string videoDate)
    {
        videoDate = _videoDate;
    } 

    public int GetVideoDuration()
    {
        return _videoDuration;
    }

    public void SetVideoDuration(int videoDuration)
    {
        videoDuration = _videoDuration;
    } 
    

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_videoName}");
        Console.WriteLine($"Published: {_videoDate}");
        Console.WriteLine($"Duration: {_videoDuration} seconds");
    }
}