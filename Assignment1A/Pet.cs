using System;

public class Pet
{
    private string name; //stores the name of the pat in text format
    private int age; //stores the age of the pat as an integer
    private bool isFemale; //determins if the pet is a boy or a girl through a true/false statement

    public void ReadName ()
    {
        Console.Write("\nName of your pet? "); //Writes the question onto the console screen
        name = Console.ReadLine(); //returns a line typed in by the user
        Console.Write("\r", name); //updates the existing line instead of moving the variable onto another line, for clarity's sake
    }

    public void ReadAge()
    {
        Console.Write("\nAge of your pet? "); //Writes the question onto the console screen
        string strAge = Console.ReadLine(); //declares a new local string variable and reads it off the console
        age = int.Parse(strAge); //converts user's input to int
        Console.Write("\r", age); //see the comment on line 13
    }

    public void ReadGender()
    {
        Console.Write("\nIs your pet a female (y/n)? "); //Writes the question onto the console screen
        char chGender = char.Parse(Console.ReadLine()); //reads user's input as a text
        if ((chGender == 'y') || (chGender == 'Y')) //determins the gender of the pet based on the user input
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.Write("\r", chGender); //see the comment on line 13
    }

    public void SummaryPet()
    {
        Console.WriteLine("\n------------------------------------------"); //just writing this for visual effect
        Console.WriteLine("Name: " + name); //re-states the name
        Console.WriteLine("Age: " + age); //re-states the age
        if (isFemale == true) //re-states the gender, based on the previous input
        {
            Console.WriteLine(name + " is a good girl!");
        }
        else
        {
            Console.WriteLine(name + " is a good boy!");
        }
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("\nPress Enter to exit!");
    }
}