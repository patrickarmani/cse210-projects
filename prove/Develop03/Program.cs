using System;

class Program
{
    static void Main(string[] args)
    {   
        
        

        Console.WriteLine("WELCOME TO SCRIPTURE MEMORIZER PROGRAM");
                
        Console.WriteLine();

        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string answer = Console.ReadLine();
        

        if (answer == "quit")
        {
            Console.WriteLine("It is finished!");
        }
        
        else
        {
            Scripture s1 = new Scripture();
            s1.RandomVersicle();
            
            Console.Write(s1.versicles);
        
        }
    
    }
}