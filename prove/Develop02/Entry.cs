using System;
using System.Collections.Generic;

namespace Develop02 
{
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;


        public string GetPrompt()
        {
            return prompt;
        }

        public string GetResponse()
        {
            return response;
        }

        public string GetDate()
        {
            return date;
        }

        public void StorePrompt(string prompt)
        {
            this.prompt = prompt;
        }

        public void StoreResponse(string response)
        {
            this.response = response;
        }
        
        public void StoreDate(string date)
        {
            this.date = date;
        }
        public List<string> Prompts()
        {
            List<string> pr = new List<string>(){"Who was the most interesting person I interacted with today?",
            "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?", "What did you think about the most today?", "If you could be any mythical creature, what would you be?"};
            return pr; 
        }

        public void Pick(List<string> pr) 
        {
            
            Random rand = new Random();
            int index = rand.Next(pr.Count);
            Console.WriteLine(pr[index]);
        }


        //Pick(Prompts())



    }
}