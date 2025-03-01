using System.Runtime.CompilerServices;

public class Assignment
{
    private string _studentName;

    private string _topic;

    public string GetName()
    {
        return _studentName;
    }

    public void SetName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string DisplayAssignment()
    {
        return $"{_studentName} - {_topic}";
    }
}