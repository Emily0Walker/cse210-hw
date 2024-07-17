// Comment.cs
public class Comment
{
    private string name;
    private string text;

    // Constructor to initialize comment properties
    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    // Method to get the name
    public string GetName()
    {
        return name;
    }

    // Method to set the name
    public void SetName(string name)
    {
        this.name = name;
    }

    // Method to get the text of the comment
    public string GetText()
    {
        return text;
    }

    // Method to set the text of the comment
    public void SetText(string text)
    {
        this.text = text;
    }
}
