// See https://aka.ms/new-console-template for more information
using AddressBook;

AddressBookEntry entry = new AddressBookEntry();
Contact con = entry.CreateContact();

Console.WriteLine("**********Contact in address Book*************");
Console.WriteLine($"First Name: {con.Firstname}");
Console.WriteLine($"Last Name: {con.LastName}");
Console.WriteLine($"Age: {con.Age}");
Console.WriteLine($"Phone Number: {con.Phonenumber}");
Console.WriteLine($"Address: {con.Address}");
Console.WriteLine($"City: {con.City}");
Console.WriteLine($"State: {con.State}");
Console.WriteLine($"Email: {con.Email}");