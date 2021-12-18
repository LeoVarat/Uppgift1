// See https://aka.ms/new-console-template for more information

using MyEvent.Logic;
var logic = new Logic();

Console.WriteLine("Sök användare via email:");
var searchValue = Console.ReadLine();
Console.WriteLine("Du har sökt på: " + searchValue);
Console.WriteLine("\n");

logic.SearchLogic.GetUser(searchValue);

Console.WriteLine("Allting funkar");