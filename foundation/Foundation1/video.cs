using System;


class Video{
    
    private string _title;

    private string _author;

    private int _duration;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title,string author, int duration){

        _title = title;
        _author= author;
        _duration = duration;

    }

    public void AddComment(Comment comment){

        _comments.Add(comment);
    }
    public void DisplayInfo(){
        
        Console.WriteLine( $"Title: {_title}, Author: {_author}, Duration: {_duration} ");

    }
    public void NumberOfComments(){
       Console.WriteLine($"Number of Comments: {_comments.Count}");



    }
    public void ListComments(){
        
        foreach (Comment x in _comments){
            Console.WriteLine(x.DisplayComment());
        }
    }
}