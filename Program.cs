using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Management System");
            //contactPersonInformation.AddingContactDetails("Lakshay", "Garg", "a", "b", "d", 3,5, "lakshay.garg");
            ContactPersonInformation contactPersonInformation = new ContactPersonInformation();
            AddressBook addressBook = new AddressBook();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter 1 to add New Address Book \nEnter 2 to Add Contacts \nEnter 3 to Edit Contacts \nEnter 4 to Delete Contacts\nEnter 5 to display all the addressbooks and contact details\nEnter 6 to delete address book\nPress any key to exit");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        addressBook.AddAdressBook();
                        //addressBook.DisplayingAddressBooks(); 
                        break;
                    case "2":
                        addressBook.AddContactsInAddressBook();
                        addressBook.DisplayingAddressBooks();
                        break;
                    case "3":
                        addressBook.EditDetailsOfAddressBook();
                        addressBook.DisplayingAddressBooks();
                        break;
                    case "4":
                        addressBook.DeleteContactsOfAddressBook();
                        addressBook.DisplayingAddressBooks();
                        break;
                    case "5":
                        addressBook.DisplayingAddressBooks();
                        break;
                    case "6":
                        addressBook.DeletingAddressBook();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
            /*contactPersonInformation.AddingContactDetails();
            contactPersonInformation.DisplayContactDetails();
           // AddressBook addressBook = new AddressBook();
            //addressBook.DisplayAddressBook();
            Console.WriteLine("Do you want to edit any details, enter y to edit.");
            string input = Console.ReadLine();
            if(input.ToLower()=="y")
            {
                contactPersonInformation.EditingContactDetails();
                contactPersonInformation.DisplayContactDetails();

            }
            Console.WriteLine("Do you want to delete anything from contact details, press y for delete");
            string inputForDelete = Console.ReadLine();
            if(inputForDelete.ToLower()=="y"|| inputForDelete=="Y")
            {
                contactPersonInformation.DeletingContactDetails();
                contactPersonInformation.DisplayContactDetails();
            }*/
        }
    }
}