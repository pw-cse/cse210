using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video();
        v1._title = "Learn C# Basics";
        v1._author = "CodeMaster";
        v1._length = 600;
        v1._comments.Add(new Comment("Alice", "Great tutorial!"));
        v1._comments.Add(new Comment("Bob", "Very helpful."));
        v1._comments.Add(new Comment("Charlie", "Thanks for sharing."));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video();
        v2._title = "OOP Explained";
        v2._author = "DevGuru";
        v2._length = 900;
        v2._comments.Add(new Comment("David", "Now I understand OOP!"));
        v2._comments.Add(new Comment("Emma", "Clear explanation."));
        v2._comments.Add(new Comment("Frank", "Awesome content."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video();
        v3._title = "Data Structures in C#";
        v3._author = "TechWorld";
        v3._length = 750;
        v3._comments.Add(new Comment("Grace", "Very informative."));
        v3._comments.Add(new Comment("Henry", "Loved this video."));
        v3._comments.Add(new Comment("Ivy", "Great examples."));
        videos.Add(v3);

        // Display videos
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($" - {comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}