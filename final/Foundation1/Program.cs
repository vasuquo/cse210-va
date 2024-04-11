using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> allVideos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Baby Shark Dance";
        video1._author = "Kids' Songs & Stories";
        video1._videoLength = "6.40";

        Video video2 = new Video();
        video2._title = "Despacito";
        video2._author = "Luis Fonsi";
        video2._videoLength = "8.30";

        Video video3 = new Video();
        video3._title = "Johny Johny Yes Papa";
        video3._author = "LooLoo Kids";
        video3._videoLength = "5.80";

        Video video4 = new Video();
        video4._title = "Shape of You";
        video4._author = "Ed Sheeran";
        video4._videoLength = "6.40";

        Comment comment1 = new Comment();
        comment1._personName =  "John Doe";
        comment1._commentText = "Great Video";

        Comment comment2 = new Comment();
        comment2._personName =  "Mary Rupet";
        comment2._commentText = "Awesome Video";

        Comment comment3 = new Comment();
        comment3._personName =  "Jane Stone";
        comment3._commentText = "I love this Video";

        Comment comment4 = new Comment();
        comment4._personName =  "Paul Gartner";
        comment4._commentText = "Exciting no dull moments";

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

    
        comment1._personName =  "Samuel";
        comment1._commentText = "This video has a strong message. People must pay more attention to it.";
        comment2._personName = "Reuben";
        comment2._commentText = "Taught provoking";
        comment3._personName = "Joseph";
        comment3._commentText = "Makes me take a look at myself";

        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);

        comment1._personName = "Victor";
        comment1._commentText = "Good comedy. I had a good laugh.";
        comment2._personName = "Adekunle";
        comment2._commentText = "This could be a life changer";
        comment3._personName = "Shade";
        comment3._commentText = "Hmmm! I love it.";
        comment4._personName = "Justin";
        comment4._commentText = "This is a good video. Please more of this.";

        video3.AddComment(comment1);
        video3.AddComment(comment2);
        video3.AddComment(comment3);
        video3.AddComment(comment4);

        comment1._personName = "Emmanuel";
        comment1._commentText = "Good comedy. I had a good laugh.";
        comment2._personName = "David Paul";
        comment2._commentText = "This could be a life changer";
        comment3._personName = "Anthony";
        comment3._commentText = "Very Good video.";
        comment4._personName = "Thomas";
        comment4._commentText = "It is a really good video. More of it.";

        video4.AddComment(comment1);
        video4.AddComment(comment2);
        video4.AddComment(comment3);
        video4.AddComment(comment4);
        
        allVideos.Add(video1);
        allVideos.Add(video2);
        allVideos.Add(video3);
        allVideos.Add(video4);
        
        Console.WriteLine("Title                  Author                Length(Sec.)  No.Of Comments");
        foreach (Video video in allVideos)
        {
            Console.WriteLine($"{video._title,-23}{video._author,-22} {video._videoLength,-15} {video._comments.Count}{video.GetComments()}");
            Console.WriteLine(" ");
        }
    }
}