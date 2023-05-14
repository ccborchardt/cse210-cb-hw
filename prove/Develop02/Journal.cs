using System;
using System.Collections.Generic;
namespace Develop02
{
    ///<summary>
    ///The responsobilty of a Journal is to hold entries
    ///</summary>
    public class Journal
    {
        public List<Entry> entries;
       

        public List<Entry> GetEntries()
        {
            return entries;
        }
         public Journal()
        {
            entries =  new List<Entry>();
        }

        public void StoreEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }   
        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
                {
                    string message = 
                    $"{entry.GetDate()}\n{entry.GetPrompt()}\n {entry.GetResponse()}\n";
                    Console.WriteLine(message);
                }
        }
    }
}