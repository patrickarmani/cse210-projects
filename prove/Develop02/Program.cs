using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal1 = new Journal();
        bool quit = false;

        while (!quit)
        {   
            Console.WriteLine();
            Console.WriteLine("WELCOME TO JOURNAL PROGRAM!");
            Console.WriteLine();
            Console.WriteLine("Choose an option bellow:");
            Console.WriteLine();
            Console.WriteLine("1. Write \n2. Display\n3. Load \n4. Save \n5. Quit");
            int UserChoose = int.Parse(Console.ReadLine());

            if (UserChoose == 1) 
            {
                
                Questions random = new Questions(); // this code create a object called Questions and a prompt is formed.
                string questions = random.AskQuestions();

                
                Console.WriteLine(questions); //Display a prompt questions formed and stores the answers
                string answer = Console.ReadLine();

                
                DateTime date = DateTime.Today; //informs the date that registration is being made

                
                Entry entry = new Entry(date.ToString("d"), questions, answer);// code that show date
                
                
                journal1.AddEntry(entry); //This code will create and save the journal
            } 
            else if (UserChoose == 2) 
            {
                journal1.DisplayJ();
            } 
            else if (UserChoose == 3)
            {
                Console.WriteLine("\nWhat is the file chosen?");
                string chosenfile = Console.ReadLine();
                journal1.LoadFile(chosenfile);
            }
            else if (UserChoose == 4)
            {
                Console.WriteLine("\nWhat name will the file receive?");
                string chosenfile = Console.ReadLine();
                journal1.SaveFile(chosenfile);
            } 
            else if (UserChoose == 5)
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("There is no such option, choose another please!");
            }
        }
    }
}