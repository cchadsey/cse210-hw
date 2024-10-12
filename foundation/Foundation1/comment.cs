using System;

class Comment{

    private string _name;

    private string _text;

    public Comment(string screenName,string commentText){

        _name = screenName;

        _text = commentText;
    }

    public string DisplayComment(){

        string commentString = _name + " Says: " + _text;

        return commentString;
    }
}