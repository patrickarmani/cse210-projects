using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal journal = new Journal();
        Console.WriteLine("********** Welcome to the Journal Program! **********");
        Console.WriteLine();

        bool play = true;
        while (play)
        {
            Console.WriteLine("These are your options. Please choose one of them. ");
            Console.WriteLine();
            Console.WriteLine("1. Write \n2. Display\n3. Load \n4. Save \n5. Quit");
            int userOption = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (userOption)
            {
                //Write
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                //Display
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                //Load
                case 3:
                    Console.Write("Which file do you want to load? ");
                    string fileToLoad = Console.ReadLine();
                    journal.LoadEntries(fileToLoad);
                    Console.WriteLine();
                    break;
                //Save
                case 4:
                    Console.Write("Type the name of the file to be saved: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveEntries(saveFileName);
                    Console.WriteLine("It worked! It's saved.");
                    Console.WriteLine();
                    break;
                //Quit
                case 5:
                    play = false;
                    Console.WriteLine("See you soon! Have a nice day! ");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("His choice was not found. Choose a number from 1 to 5 please.");
                    break;
            }
        }
    }
}

