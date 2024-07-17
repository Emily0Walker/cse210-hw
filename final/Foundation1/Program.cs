class Program 
{ public static void Main(string[] args)
    {
        // Create an instance of Video
        Video videoManager = new Video("Initial Title", "Initial Author", 0);


        // Create videos and add comments
        videoManager.CreateVideos();

        // Display all videos and their comments
        videoManager.DisplayVideos();
    }
}