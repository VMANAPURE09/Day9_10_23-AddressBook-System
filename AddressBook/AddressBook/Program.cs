﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            ContactOperation newContactOperation = new ContactOperation();
            Contact newcontact = new Contact();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Delete contact \n5. Add contact \n6. Add multiple Address Book with unique name \n7. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        newContactOperation.AddContact(newcontact);
                        newContactOperation.Display();
                        break;
                    case 3:
                        newContactOperation.Editexistingcontact();
                        newContactOperation.Display();
                        break;
                    case 4:
                        newContactOperation.Deletecontact();
                        newContactOperation.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information first name, last names, address,city, state, zip, phone number and email id");
                        newcontact.firstname = Console.ReadLine();
                        newcontact.lastname = Console.ReadLine();
                        newcontact.address = Console.ReadLine();
                        newcontact.city = Console.ReadLine();
                        newcontact.state = Console.ReadLine();
                        newcontact.zip = Console.ReadLine();
                        newcontact.phonenumber = Console.ReadLine();
                        newcontact.emailid = Console.ReadLine();
                        newContactOperation.AddContact(newcontact);
                        newContactOperation.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string name = Console.ReadLine();
                        newContactOperation.AddUniqueContact(name);
                        newContactOperation.DisplayUniqueContacts();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
