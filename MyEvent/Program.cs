// See https://aka.ms/new-console-template for more information

using MyEvent.Logic;
var logic = new Logic();

Console.WriteLine("Sök användare via email:");
var searchValue = Console.ReadLine();
Console.WriteLine("Du har sökt på: " + searchValue);
Console.WriteLine("\n");

logic.SearchLogic.GetUser(searchValue);

Console.WriteLine("\n");

logic.SearchLogic.GetUsers();

Console.WriteLine("\n");

logic.DeleteLogic.DeleteUser(1);

Console.WriteLine("\n");

Console.WriteLine("Ange sök väg för dokumentet om du vill annars tryck bara enter: ");

var path = Console.ReadLine();

logic.ExportLogic.ExportUsers(path);



Console.WriteLine("Allting funkar");