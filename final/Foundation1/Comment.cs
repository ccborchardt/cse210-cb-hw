using System;
using System.Collections.Generic;

class Comment
{
    public string _name { get; }
    public string _text { get; }

    public Comment(string Name, string Text)
    {
        _name = Name;
        _text = Text;
    }
}