// See https://aka.ms/new-console-template for more information

using MyEvent.Logic;
var logic = new Logic();


var exit = false;

do
{
    Console.WriteLine("Välj ett alternativ från menyn");
    Console.WriteLine("\n");
    Console.WriteLine("1) Sök efter en deltagare");
    Console.WriteLine("\n");
    Console.WriteLine("2) Visa alla deltagare");
    Console.WriteLine("\n");
    Console.WriteLine("3) Radera en deltagare");
    Console.WriteLine("\n");
    Console.WriteLine("4) Tilldela en rabbatkod och en deltagare");
    Console.WriteLine("\n");
    Console.WriteLine("5) Exportera en lista på alla användare");
    Console.WriteLine("\n");
    Console.WriteLine("6) Stäng av applikationen");
    Console.WriteLine("\n");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            Console.WriteLine("\n");
            Console.WriteLine("Sök användare via email:");
            Console.WriteLine("\n");
            var searchValue = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Du har sökt på: " + searchValue);
            Console.WriteLine("\n");
            logic.SearchLogic.GetUser(searchValue);
            Console.WriteLine("\n");
            break;
        case "2":
            Console.WriteLine("\n");
            logic.SearchLogic.GetUsers();
            Console.WriteLine("\n");
            break;
        case "3":
            Console.WriteLine("\n");
            Console.WriteLine("Ange id på den deltagaren du vill radera");
            Console.WriteLine("\n");
            var userId = Console.ReadLine();
            Console.WriteLine("\n");
            logic.DeleteLogic.DeleteUser(userId);
            Console.WriteLine("\n");
            break;
        case "4":

            break;
        case "5":
            Console.WriteLine("\n");
            Console.WriteLine("Ange sökväg där du vill spara dokumentet annars lämna fältet tomt och tryck bara enter: ");
            Console.WriteLine("\n");
            var path = Console.ReadLine();
            Console.WriteLine("\n");
            logic.ExportLogic.ExportUsers(path);
            Console.WriteLine("\n");
            break;
        case "6":
            Console.WriteLine("\n");
            Console.WriteLine("Stäng av applikationen");
            exit = true;
            Console.WriteLine("\n");
            break;
        default:
            Console.WriteLine("\n");
            Console.WriteLine("Ogiltigt val, försök igen");
            Console.WriteLine("\n");
            break;
    }
} while (exit != true);
