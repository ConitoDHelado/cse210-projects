public class Comment
{
    private string _name;
    private string _body;

    public Comment(string name, string body)
    {
        _name = name;
        _body = body;
    }

    public string GetDisplayComment()
    {
        string comment = $"\t· {_name}:\n\t\x1B[3m\"{_body}\"\x1B[0m";
        return comment;
    }


}