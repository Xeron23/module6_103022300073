using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    private Random random = new Random();
    public SayaTubeVideo(string title)
    {
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount =0;
    }
    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("id. " + id + ", title: " + title + ", playCount: " + playCount);
    }
    public int getPlayCount()
    {
        return playCount;
    }

    public string getTitle()
    {
        return title;
    }

}

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos = new List<SayaTubeVideo>();
    private string usernmae;
    private Random random = new Random();

    public SayaTubeUser(string username)
    {
        this.id = random.Next(10000, 100000);
        this.usernmae = username;
    }

    public int getTotalVideoPlayCount()
    {
        int totalPLayVideo = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            totalPLayVideo += uploadedVideos[i].getPlayCount();
        }
        return totalPLayVideo;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }
    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User: " + usernmae);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            Console.WriteLine("\n");
        }
    }

}

public class Program
{
    public static void Main()
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review film film1 Rifki");
        video1.IncreasePlayCount(20);
        SayaTubeVideo video2 = new SayaTubeVideo("Review film film2 Rifki");
        video2.IncreasePlayCount(20);
        SayaTubeVideo video3 = new SayaTubeVideo("Review film film3 Rifki");
        video3.IncreasePlayCount(20);
        SayaTubeVideo video4 = new SayaTubeVideo("Review film film4 Rifki");
        video4.IncreasePlayCount(20);
        SayaTubeVideo video5 = new SayaTubeVideo("Review film film4 Rifki");
        video5.IncreasePlayCount(20);
        SayaTubeVideo video6 = new SayaTubeVideo("Review film film5 Rifki");
        video6.IncreasePlayCount(20);
        SayaTubeVideo video7 = new SayaTubeVideo("Review film1 film6 Rifki");
        video7.IncreasePlayCount(20);
        SayaTubeVideo video8 = new SayaTubeVideo("Review film1 film7 Rifki");
        video8.IncreasePlayCount(40);
        SayaTubeVideo video9 = new SayaTubeVideo("Review film1 film8 Rifki");
        video9.IncreasePlayCount(10);
        SayaTubeVideo video10 = new SayaTubeVideo("Review film1 film9 Rifki");
        video10.IncreasePlayCount(20);
        SayaTubeVideo video11 = new SayaTubeVideo("Review film1 film10 Rifki");
        video11.IncreasePlayCount(20);

        SayaTubeUser user1 = new SayaTubeUser("Rifki");
        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);
        user1.AddVideo(video9);
        user1.AddVideo(video10);
        user1.AddVideo(video11);


        user1.PrintAllVideoPlayCount();
        Console.WriteLine("Total pemutaran: " + user1.getTotalVideoPlayCount());

    }
}