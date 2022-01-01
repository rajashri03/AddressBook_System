using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookEntry
    {
        public Contact[] entries;//Array of object
        public int totalentries = 0;
        public int Size;

        /// <summary>
        /// Parameterizd Constructor
        /// </summary>
        /// <param name="size"></param>
        public AddressBookEntry(int size)
        {
            entries = new Contact[size];
            Size = size;
        }
        //Created list of contact
        List<Contact> list = new List<Contact>();
        /// <summary>
        /// Created Contact in address book
        /// </summary>
        /// <returns></returns>
        public Contact CreateContact()
        {
            Contact con = new Contact();
            Console.WriteLine("***************Address Book Size is 2********************");
            Console.WriteLine("Enter First Name");
            con.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            con.LastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            con.Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber");
            con.Phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Address");
            con.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            con.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            con.State = Console.ReadLine();
            Console.WriteLine("Enter Email");
            con.Email = Console.ReadLine();
            return con;
            list.Add(con);
        }
        public void AddNewEntry()
        {
            Contact newContact = CreateContact();
            list.Add(newContact);
            if (totalentries < entries.Length)
            {
                entries[totalentries++] = newContact;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Added successfuly!");
                Console.ResetColor();

                Console.WriteLine("\n*****-> Details Of Person  <-*****");
                Console.WriteLine($"First Name: {newContact.Firstname}");
                Console.WriteLine($"Last Name: {newContact.LastName}");
                Console.WriteLine($"City Name: {newContact.City}");
                Console.WriteLine($"State Name: {newContact.State}");
                Console.WriteLine($"Phone Number: {newContact.Phonenumber}");
                Console.WriteLine($"Email: {newContact.Email}");
            }
            else
            {
                Console.WriteLine("Address Book is full");
            }
        }
        internal static void ShowAllDetails(Contact person)
        {
            Console.WriteLine("**********Contact in address Book*************");
            Console.WriteLine($"First Name: {person.Firstname}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Phone Number: {person.Phonenumber}");
            Console.WriteLine($"Address: {person.Address}");
            Console.WriteLine($"City: {person.City}");
            Console.WriteLine($"State: {person.State}");
            Console.WriteLine($"Email: {person.Email}");
        }
    }
}
