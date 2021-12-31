using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookEntry
    {
        //Created list of contact
        List<Contact> list = new List<Contact>();
        /// <summary>
        /// Created Contact in address book
        /// </summary>
        /// <returns></returns>
        public Contact CreateContact()
        {
            Contact con = new Contact();
            Console.WriteLine("***************Address Book********************");
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
        }
    }
}
