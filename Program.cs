using System.Drawing;
{
    Console.WriteLine(" input Color");
    int numberOfColors = 5;
    Console.Write("Choose Any Of the colours : Black || Green || Blue  || White || Red");
    Console.WriteLine("");
    Console.Write("====Choose Color===   :  ");
    string Colours = Console.ReadLine()!;
    string[] myColor = new string[numberOfColors];

    myColor = ["Black", "Green", "Blue", "White", "Red"];
    if (Colours == "Black")
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine($"You Have Choose color {Colours} ");
        Console.ResetColor();

    }
    else if (Colours == "Green")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine($"You Have Choose color {Colours} ");
        Console.ResetColor(); 
    }
    else if (Colours == "Blue")
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine($"You Have Choose color {Colours} ");
        Console.ResetColor();
    }
    else if (Colours == "White")
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"You Have Choose color {Colours} ");
        Console.ResetColor();
    }
    else if (Colours == "Red")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"You Have Choose color {Colours} ");
        Console.ResetColor();
    }
    else
     {
     Console.WriteLine($" Invalid Color : \n {Colours.ToUpper()}");
     }
}

