

public class Video
{
    private string Title;
    private string Author;
    private int VideoLength;
    private List<Video> videoList;
    private List<Comment> comments; // List to store comments

    // Constructor to initialize video properties
    public Video(string title, string author, int videoLength)
    {
        Title = title;
        Author = author;
        VideoLength = videoLength;
        videoList = new List<Video>();
        comments = new List<Comment>(); // Initialize the comments list
    }

    // Method to get the title
    public string GetTitle()
    {
        return Title;
    }

    // Method to set the title
    public void SetTitle(string title)
    {
        Title = title;
    }

    // Method to get the author
    public string GetAuthor()
    {
        return Author;
    }

    // Method to set the author
    public void SetAuthor(string author)
    {
        Author = author;
    }

    // Method to get the video length
    public int GetVideoLength()
    {
        return VideoLength;
    }

    // Method to set the video length
    public void SetVideoLength(int videoLength)
    {
        VideoLength = videoLength;
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the list of comments
    public List<Comment> GetComments()
    {
        return comments;
    }
        public void CreateVideos()
    {
        // Creating 3 sample videos
        Video video1 = new Video("Sample Video 1", "Author 1", 10);
        Video video2 = new Video("Sample Video 2", "Author 2", 20);
        Video video3 = new Video("Sample Video 3", "Author 3", 30);

        // Adding videos to the list
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        // Adding comments to video1
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "Loved it!"));

        // Adding comments to video2
        video2.AddComment(new Comment("User1", "Nice content."));
        video2.AddComment(new Comment("User3", "Well explained."));
        video2.AddComment(new Comment("User4", "Good job!"));

        // Adding comments to video3
        video3.AddComment(new Comment("User2", "Excellent!"));
        video3.AddComment(new Comment("User4", "Very helpful."));
        video3.AddComment(new Comment("User5", "Awesome!"));
    }

    // Method to display all videos and their comments
    public void DisplayVideos()
    {
        foreach (var video in videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetVideoLength()} mins");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  Comment by {comment.GetName()}: {comment.GetText()}");
            }
        }
    }
}
