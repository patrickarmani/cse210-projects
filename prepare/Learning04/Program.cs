using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string homeWork = mathAssignment.GetSummary();
        string homeWork2 = mathAssignment.GetHomeworkList();
        Console.WriteLine(homeWork);
        Console.WriteLine(homeWork2);

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        string writing = writingAssignment.GetSummary();
        string writing2 = writingAssignment.GetWritingInformation();
        Console.WriteLine(writing);
        Console.WriteLine(writing2);


    }
}