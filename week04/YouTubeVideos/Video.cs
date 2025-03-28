public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }

    public void AddToComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        int nComments = _comments.Count();
        return nComments;
    }

    public void DisplayVideoData()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        int n = GetNumberOfComments();
        Console.WriteLine($"Comments: {n}");

        foreach (Comment comment in _comments)
        {
            string displayComment = comment.GetDisplayComment();
            Console.WriteLine(displayComment);

        }
    }
}