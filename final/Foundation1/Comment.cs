// Comment.cs
public class Comment
{
    private string Name;
    private string Text;

    // Constructor to initialize comment properties
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Method to get the name
    public string GetName()
    {
        return Name;
    }

    // Method to set the name
    public void SetName(string name)
    {
        Name = name;
    }

    // Method to get the text of the comment
    public string GetText()
    {
        return Text;
    }

    // Method to set the text of the comment
    public void SetText(string text)
    {
        Text = text;
    }
}
