using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Entry
{
    public string _question;
    public string _userAnswer;
    public string _date;
        

    public void ShowDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void RandomQuestions()
    {
        List<string> questions = new List<string>()
    {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "List the places I have been to today.",
    "List the 3 things you are grateful for today and why.",
    "What did you do today to bless someone's life?",
    "What scripture have you studied today? What did you learn from her?",
    "What steps did you take today towards a goal you’re working on?",
    "How would you describe your spirituality today?",
    "Would you change any of the decisions you made today?",
    };

        Random rand = new Random();
        int randomIndex = rand.Next(questions.Count);
        _question = questions[randomIndex];
        Console.WriteLine(_question);
    }

    public void DisplayUserAnswer()
    {
        Console.Write("> ");
        _userAnswer = Console.ReadLine();
    }
}