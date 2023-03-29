using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
    
        Reference scriptureSearch = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(scriptureSearch,  "Trust in the lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        Words word1 = new Words(scripture);
        

        string userEntry = " ";

        while (userEntry != "quit" && word1.hasWordsLeft() == true)
        {
            Console.Clear(); // This will clear the console
            Console.WriteLine(string.Format("{0} {1}", scriptureSearch.toString(), word1.toString()));
            Console.WriteLine();
            userEntry = Console.ReadLine();
            word1.removeWords();

        }
        Console.Clear();
        Console.WriteLine(string.Format("{0} {1}", scriptureSearch.toString(), word1.toString()));
        Console.WriteLine();
        Console.WriteLine("Excellent!!");
    }
}