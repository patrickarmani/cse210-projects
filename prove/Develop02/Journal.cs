using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Journal
{
    public List<Entry> _entryList = new List<Entry> {};

    public Journal()
    {

    }

    public void DisplayJ()
    {
        foreach (Entry entry in _entryList)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry entry)
    {   
        _entryList.Add(entry);
    }

    public void LoadFile(string chosenfile)
    {
        try 
        {
            string[] lines = System.IO.File.ReadAllLines(chosenfile);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(" ~ ");
                
                string date = parts[0];
                string questions = parts[1];
                string answer = parts[3];


                Entry entry = new Entry(date, questions, answer);

                _entryList.Add(entry);
            }
        } 
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File not found! ERROR: {e.Message}");
        }
        catch (System.IndexOutOfRangeException e)
        {
            Console.WriteLine($"File could not be read, one or multiple rows present issues. ERROR: {e.Message}");
        }

    }

    public void SaveFile(string chosenfile)
    {
        using (StreamWriter outputFile = new StreamWriter(chosenfile))
        {
            foreach (Entry entry in _entryList) {
                string entryLine = entry.CompleteText();
                outputFile.WriteLine(entryLine);
            }
            
        }
    }
}
