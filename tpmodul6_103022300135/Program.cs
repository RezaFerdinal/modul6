﻿using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 999999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + id);
        Console.WriteLine("Totle: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }
}

class Program
{
    static void Main(string[]args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design Ny Contract - Muhammad_Reza_Ferdinal");
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}
