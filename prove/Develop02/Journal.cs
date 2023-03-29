using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public void NewEntry()
    {
        Entry userEntry = new Entry();
        userEntry.ShowDate();
        userEntry.RandomQuestions();
        userEntry.DisplayUserAnswer();
        _entries.Add(userEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine();
            Console.WriteLine($"Prompt: {entry._question}");
            Console.WriteLine($"{entry._userAnswer}");
            Console.WriteLine();
        }
    }

    public void LoadEntries(string filename)
    {
        if (filename.EndsWith(".doc"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string question = parts[1];
                string answer = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {question}");
                Console.WriteLine($"{answer}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }

    public void SaveEntries(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".doc"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._question},{entry._userAnswer}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date:{entry._date},{entry._question},{entry._userAnswer}");
                    outputFile.WriteLine($"Prompt:{entry._question}");
                    outputFile.WriteLine($"{entry._userAnswer}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}
