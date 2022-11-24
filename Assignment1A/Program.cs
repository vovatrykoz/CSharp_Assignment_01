using System;

namespace Assignment1A
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = ("Pet Owner");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();


            Console.WriteLine("\nChoose the program to start: Pet Owner or Book (type the first letter of the respective program,'p' or 'b', ignore the quotes)'\n"); //Writes the question onto the console screen, which gives the user a choice of which program to start
            char chProgram = char.Parse(Console.ReadLine()); //reads user's input as a text
            Console.Clear(); //clears the screen, so that the user is not distracted by the question

            if ((chProgram == 'p') || (chProgram == 'P')) //depending on which program the user chooses, the corresponding class will be adressed
            {
                Pet pet = new Pet(); //creates a Pet-class object
                pet.ReadName(); //actives the ReadName method established in Pet.cs
                pet.ReadAge();  //actives the ReadAge method established in Pet.cs
                pet.ReadGender();  //activates the ReadGender method established in Pet.cs
                pet.SummaryPet(); //Loads the summary method
            }
            else
            {
                Book book = new Book(); //works similar to the Pet.cs except now it adresses the Book.cs 
                book.ReadTitle();
                book.ReadAuthor();
                book.ReadPublicationYear();
                book.SummaryShirt();
            }

            Console.ReadLine();

            

        }
    }

}