using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Questions 
{
    
    public List<string> _questionsList = new List<string> 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    
    public Questions()
    {

    }

    public string AskQuestions()
    {
        Random random = new Random();
        string questions = _questionsList[random.Next(1, 5)];
        return questions;
    }
}