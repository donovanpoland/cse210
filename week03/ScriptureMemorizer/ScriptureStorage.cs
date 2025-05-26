


using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureStorage
{
    private List<(Reference, string)> scriptures = new List<(Reference, string)>();

    public ScriptureStorage(string filePath)
    {
        LoadScripturesFromFile(filePath);
        
    }

    //load a scripture from the file
    private void LoadScripturesFromFile(string filePath)
    {
        foreach (var line in File.ReadAllLines(filePath))
        {
            string[] parts = line.Split('|');

            if (parts.Length == 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int startVerse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = (endVerse == 0)
                    ? new Reference(book, chapter, startVerse)
                    : new Reference(book, chapter, startVerse, endVerse);

                scriptures.Add((reference, text));
            }
        }
    }

    //find a random scripture to load
    public (Reference, string) GetRandomScripture()
    {
        Random rand = new Random();
        int index = rand.Next(scriptures.Count);
        return scriptures[index];
    }
}