using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTube Videos");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Como Instalar Visual Studio Community y Crear tu Primer Programa en C#", "PrograLabs", 445);
        video1.AddComment(new Comment("Antonio", "This tutorial is amazing! Thank you!"));
        video1.AddComment(new Comment("rosa", "Very clear explanations."));
        video1.AddComment(new Comment("elvis", "video I've seen so far."));
        videos.Add(video1);


        Video video2 = new Video("JALIFE:La debilidad de Trump son los 4 jinetes de las finanzas controlando medios occidentales", "negocios polite.", 1425);
        video2.AddComment(new Comment("oscar", "The only ones for a long time who were called the 4 horsemen (almost of the apocalypse) of the banking financiers."));
        video2.AddComment(new Comment("Tanya", "Always seeing the big picture, Dr. Jalife."));
        video2.AddComment(new Comment("julio", "An interview with the master Jalife is a masterclass... greetings and congratulations."));
        videos.Add(video2);


        Video video3 = new Video("VARIABLES Y OPERADORES", "Thomas Editz", 445);
        video3.AddComment(new Comment("cyberlando", "This video didnt get enough respect! you did great on this!"));
        video3.AddComment(new Comment("irma", "Very clear explanations."));
        video3.AddComment(new Comment("elvis", "I've had problems from the start"));
        videos.Add(video3);

        Video video4 = new Video("Star Wars | Heroes", "Thomas Editz", 445);
        video4.AddComment(new Comment("Antonio", "The force is strong with this video"));
        video4.AddComment(new Comment("rosa", "the transition from the battle of geonoisis to obi wan on tattoine is so clean "));
        video4.AddComment(new Comment("elvis", "Can’t wait but I’ll watch it later cuz I’ll be driving to LONDON"));
        videos.Add(video4);

        foreach (var video in videos)
        {
            video.DisplayVideo();
        }

        Console.WriteLine("Programa finalizado.");
    }
}