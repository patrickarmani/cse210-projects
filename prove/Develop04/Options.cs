using System;

public class Options
{
    // Attributes 
    private string _menu = $@"
Menu Options

******************************************

Select one:
1. Start breathing activity
2. Start reflecting activity
3. Start listing activity
4. Quit

******************************************

Select an option from the menu:  ";

    public string _userInput;
    private int _userOption = 0;

    // Methods
    public int UserOption()
    // Method to display options to user
    {
        // This will clear the console
        Console.Clear();
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userOption = 0;
        // This block catches any non integer values that are entered
        try
        {
            _userOption = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userOption = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userOption;
    }



}


