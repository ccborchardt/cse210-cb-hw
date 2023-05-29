using System;

namespace Develop03
{
   public class ScriptureReference
   {
        public string Book { get; }
        public int Chapter { get; }
        public int VerseStart { get; }
        public int VerseEnd { get; }
        public bool IsSingleVerse { get; }

        public ScriptureReference(string reference)
        {
            string[] parts = reference.Split(':');
            string[] bookAndChapter = parts[0].Split(' ');

            Book = bookAndChapter[0];
            Chapter = int.Parse(bookAndChapter[1]);

            string[] verseParts = parts[1].Split('-');
            VerseStart = int.Parse(verseParts[0]);

            if (verseParts.Length > 1)
            {
                VerseEnd = int.Parse(verseParts[1]);
            }
            else
            {
                VerseEnd = VerseStart;
            }

            IsSingleVerse = VerseStart == VerseEnd;
        }

        public string GetFormattedReference()
        {
            if (IsSingleVerse)
            {
                return $"{Book} {Chapter}:{VerseStart}";
            }
            else
            {
                return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
            }
        }
    }
}