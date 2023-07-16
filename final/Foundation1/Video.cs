using System;
using System.Collections.Generic;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments;

    public string Title 
    {
        get { return _title;}
        set {_title = Title;}
    }

    public string Author 
    {
        get {return _author;}
        set {_author = Author;}
    } 

    public int Length 
    {
        get {return _length;}
        set {_length = Length;}
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    comments = new List<Comment>();
    }

     public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }
    public IReadOnlyList<Comment> GetComments()
    {
        return comments.AsReadOnly();
    }
}