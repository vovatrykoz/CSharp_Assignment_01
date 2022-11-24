using System;

public class Book
{
    private string title; //stores the name of the pat in text format
    private string author; //stores the age of the pat as an integer
    private int publicationYear; //determins if the pet is a boy or a girl through a true/false statement

    public void ReadTitle()
    {
        Console.Write("\nTitle of the book? "); //Writes the question onto the console screen
        title = Console.ReadLine(); //returns a line typed in by the user
        Console.Write("\r", title); //updates the existing line instead of moving the variable onto another line, for clarity's sake
    }

    public void ReadAuthor()
    {
        Console.Write("\nAuthor of the book? "); //Writes the question onto the console screen
        author = Console.ReadLine(); //reads user's input as a text
        Console.Write("\r", author); //see the comment on line 13
    }

    public void ReadPublicationYear()
    {
        Console.Write("\nPublication year? "); //Writes the question onto the console screen
        string strYear = Console.ReadLine(); //declares a new local string variable and reads it off the console
        publicationYear = int.Parse(strYear); //converts user's input to int
        Console.Write("\r", publicationYear); //see the comment on line 13
    }


    public void SummaryShirt()
    {
        Console.WriteLine("\n------------------------------------------");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Publication year: " + publicationYear);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("\nPress Enter to exit!");
    }
}