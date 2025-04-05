using System;
using System.Collections.Generic;
public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
// class Comments
// {
//     private string _comments;

//     public string GetComments()
//     {
//         return _comments;
//     }

//     public void SetComments(string comments)
//     {
//         _comments = comments;
//     }

//     public void DisplayComments()
//     {
//         Console.WriteLine(_comments);
//     }

    
// }