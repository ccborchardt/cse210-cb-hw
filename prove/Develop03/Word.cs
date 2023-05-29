using System;

namespace Develop03
{
    class Word
    {
        public string Text { get; set; }
        public bool IsHidden { get; set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }
    }
}