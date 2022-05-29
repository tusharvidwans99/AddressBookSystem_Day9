namespace AddressBookSystem
{
    public class Program
    {
        /// <summary>
        /// This program is used to Add, create, remove,edit the Address Book of the Peoples.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            CreateContact createContact = new CreateContact();

            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Enter \'add\' to Add a Person,\nEnter \'list\' to list the Persons\nEnter \'Edit\' to edit a Person\nEnter \'remove\' to remove the contact: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        createContact.AddPerson();
                        break;
                    case "list":
                        createContact.ListPeople();
                        break;
                    case "edit":
                        Console.Write("Enter the Full Name of the Person name you want to edit: ");
                        string Name = Console.ReadLine();
                        createContact.Edit(Name.Trim());
                        break;
                    case "remove":
                        Console.Write("Enter the Full Name of the Person name you want to remove from Address Book: ");
                        string FullName = Console.ReadLine();
                        createContact.remove(FullName);
                        break;
                }

                Console.WriteLine("Enter \'exit\' to exit the AddressBook or \'1\' to continue");
                command=Console.ReadLine();
            }
        }
    }
}