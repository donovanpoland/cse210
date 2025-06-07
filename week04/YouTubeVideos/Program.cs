using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to design classes in C#", "Donovan Poland", 300);
        video1.AddComment(new Comment("Alice", "Very informative!"));
        video1.AddComment(new Comment("Bob", "Thanks, helped me a lot."));
        video1.AddComment(new Comment("Charlie", "Great explanation."));

        Video video2 = new Video("Introduction to Javascript", "Donovan, Poland", 480);
        video2.AddComment(new Comment("Dan", "I love JS!"));
        video2.AddComment(new Comment("Eva", "Nice pace and clarity."));
        video2.AddComment(new Comment("Frank", "Good examples."));

        Video video3 = new Video("Java Basics: Classes and Objects", "Donovan Poland", 410);
        video3.AddComment(new Comment("George", "Very beginner-friendly."));
        video3.AddComment(new Comment("Hannah", "Finally understand constructors!"));
        video3.AddComment(new Comment("Ivan", "Clear and concise."));

        Video video4 = new Video("Getting Started with Python", "Donovan Poland", 275);
        video4.AddComment(new Comment("Jill", "Python is so fun to learn!"));
        video4.AddComment(new Comment("Kyle", "Loved the snake analogy!"));
        video4.AddComment(new Comment("Liam", "Make more tutorials please."));


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}