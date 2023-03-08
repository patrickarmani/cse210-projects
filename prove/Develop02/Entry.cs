using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Entry
{
    public string _questions;
    public string _date;
    public string _answer;


    public Entry(string date, string questions, string answer)
    {
        this._questions = questions;
        this._date = date;
        this._answer = answer;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_date} - Prompt Questions: {_questions}");
        Console.WriteLine($"{_answer}");
    }

    public string CompleteText()
    {
        string text = $"{_date},{_questions},{_answer}";
        return text;
    }
}
