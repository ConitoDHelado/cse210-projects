using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video;
        string title;
        string author;
        int length;

        Comment comment;
        string commentName;
        string commentBody;
        int nVideos = 4;
        int nComments = 3;
        for (int i = 0; i < nVideos; i++)
        {
            title = $"Video #{i+1}";
            author =$"Author #{i+1}";
            length = 260;
            video = new Video(title, author, length);
            videos.Add(video);

            // Video 1 Comment 1
            for (int j = 0; j < nComments; j++)
            {
                commentName = $"Person {j+1}";
                commentBody = $"This is a sample text for comment {j+1} in video #{i+1}";
                comment = new Comment(commentName, commentBody);
                video.AddToComments(comment);
            }
            
        }

        Console.WriteLine("==================");
        foreach (Video addedVideo in videos)
        {
            addedVideo.DisplayVideoData();
            Console.WriteLine("==================");
        }

    }
}