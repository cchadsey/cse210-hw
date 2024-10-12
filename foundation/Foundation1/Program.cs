using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("day out with bob","Anthony2", 472);
        Comment com1 = new Comment("newguy1","I got here first!");
        video1.AddComment(com1);
        Comment com2 = new Comment("twoguy","You Beat Me!");
        video1.AddComment(com2);
        Comment com3 = new Comment("shadowHunter","Cool Stuff");
        video1.AddComment(com3);

        videos.Add(video1);

        Video video2 = new Video("Nightwalkers","VoteForIsolation", 4992);
        Comment com12 = new Comment("newguy2","I got here first!");
        video2.AddComment(com12);
        Comment com22 = new Comment("twoguy2","You Beat Me!");
        video2.AddComment(com22);
        Comment com32 = new Comment("shadowHunter2","Cool Stuff");
        video2.AddComment(com32);

        videos.Add(video2);

        Video video3 = new Video("My thoughts on the expulsion of volitile compounds from polymer based wall coverings","HermioneG", 634399682);
        Comment com13 = new Comment("newguy3","My wife gave birth to our first child just before i started this video. That child just graduated college.");
        video3.AddComment(com13);
        Comment com23 = new Comment("twoguy3","Why did she choose that shade of brown?");
        video3.AddComment(com23);
        Comment com33 = new Comment("shadowHunter3","I've never been less interested in drying paint.");
        video3.AddComment(com33);

        videos.Add(video3);
        
        foreach (Video vid in videos){
            vid.DisplayInfo();
            vid.NumberOfComments();
            vid.ListComments();
        }
    }
}