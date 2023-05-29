using System;
using System.Collections.Generic;
using System.IO;

namespace Develop03
{
    public class Scripture
    {
        private List<Word> words;

        public ScriptureReference Reference { get; }
        private IReadOnlyList<Word> Words => words.AsReadOnly();

        public Scripture(string reference, string text)
        {
            Reference = new ScriptureReference(reference);
            words = new List<Word>();

            string[] wordArray = text.Split(' ');

            foreach (string word in wordArray)
            {
                words.Add(new Word(word));
            }
        }

        public void HideWords(int count)
        {
            int wordsToHide = Math.Min(count, words.Count - GetHiddenWordCount());

            Random random = new Random();
            HashSet<int> indices = new HashSet<int>();

            while (indices.Count < wordsToHide)
            {
            int index = random.Next(words.Count);
            indices.Add(index);
            }

            foreach (int index in indices)
            {
            words[index].IsHidden = true;
            }
        }

        public bool AllWordsHidden()
        {
            return GetHiddenWordCount() == words.Count;
        }

        private int GetHiddenWordCount()
        {
            int count = 0;

            foreach (Word word in words)
            {
                if (word.IsHidden)
                {
                    count++;
                }
            }

            return count;
        }

        public string GetFormattedText()
        {
            string formattedText = $"{Reference.GetFormattedReference()}: ";

            foreach (Word word in words)
            {
                if (word.IsHidden)
                {
                    formattedText += "____ ";
                }
                else
                {
                    formattedText += word.Text + " ";
                }
            }

            return formattedText.Trim();
        }
    }
}