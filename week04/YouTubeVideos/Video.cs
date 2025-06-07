using System.ComponentModel;
using System.Transactions;

public class Video
{
    //variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //constructors
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    //methods
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
        }
    }

    public void AddComment(Comment comment)
    {
       _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
}