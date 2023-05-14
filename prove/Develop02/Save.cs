using System;
using System.IO;
using System.Collections.Generic;

namespace Develop02
{
    public class Save
    {
        public string filename;

        public string GetFileName()
        {
            return filename;
        }
        
        public void saveFile(string filename, List<Entry> entries)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine(entries);
                }
            }

        }
        
        public void csvDisplay(string GetFileName)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");

                Console.WriteLine(parts);
            }
        }
        
        public string[] Filelist()
        {
            string[] filelist = Directory.GetFiles("C:/Users/chant/OneDrive/Documents/BYU-I/210 GIT/cse210-cb-hw/prove/Develop02", "*.txt");
            return filelist;
        }



    }

}