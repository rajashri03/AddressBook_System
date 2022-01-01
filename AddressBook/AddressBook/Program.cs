// See https://aka.ms/new-console-template for more information
using AddressBook;

AddressBookEntry entry = new AddressBookEntry(1);
Contact con = entry.CreateContact();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Address book options:\n add - To Add New Entry.\nquit - TO Leave.\n");
Console.Write("Option: ");
Console.ResetColor();
string Instruction = Console.ReadLine();
while (true)
{
    if (Instruction.ToLower() == "quit")//Checking For Option
    {
        Console.WriteLine("GoodBye!");
        break;
    }
    else if (Instruction.ToLower() == "add")//Checking For Option
    {
        entry.AddNewEntry();
        AddressBookEntry.ShowAllDetails(con);
    }
    else
    {
        Console.WriteLine("Invalid Input!");
    }
}