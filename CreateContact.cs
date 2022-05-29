using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContact
    {
        public List<Person> People = new List<Person>();

        //This method will check if the Address Book is empty or not.
        public void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:");
            for(int i=0; i < People.Count;i++)
            {
                PrintPerson(People[i]);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }



        //This method will Add the Person Contact.
        public void AddPerson(int a=-1)
        {

            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine().Trim();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine().Trim();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine().Trim();

            Console.Write("Enter Your Address\nEnter Area/Colony Name: ");
            
            person.Area = Console.ReadLine().Trim();
            Console.Write("Enter CityName: ");
            person.City = Console.ReadLine().Trim();
            Console.Write("Enter State: ");
            person.State = Console.ReadLine().Trim();
            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine().Trim();
            

            if (a == -1)
            {
                People.Add(person);
            }
            else
            {
                People.Insert(a,person);
            }

            
        }


        //This Method will print the Peron details.
        public void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: Area " + person.Area);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("ZipCOde: " + person.ZipCode);
            Console.WriteLine("-------------------------------------------");
        }


        public void Edit(string Name)
        {
            
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].FirstName.ToLower() +" "+ People[i].LastName.ToLower() == Name.ToLower())
                {
                    Console.WriteLine("Which thing do you want to change: ");
                    Console.WriteLine("Enter \'1\' for First Name\n\'2\' for LastName\n\'3 for Phone Number\n\'4\' for Address\n\'5\' for All");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.Write("Enter the First Name: ");
                            People[i].FirstName = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 2:
                            Console.Write("Enter the Last Name: ");
                            People[i].LastName = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 3:
                            Console.Write("Enter Phone Number: ");
                            People[i].PhoneNumber = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 4:
                            Console.Write("Enter Area/Colony Name: ");
                            People[i].Area = Console.ReadLine();
                            Console.WriteLine("Enter City Name: ");
                            People[i].City = Console.ReadLine();
                            Console.WriteLine("Enter State Name: ");
                            People[i].State = Console.ReadLine();
                            Console.WriteLine("Enter Zip Code: ");
                            People[i].ZipCode = Console.ReadLine();
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        case 5:
                            AddPerson(i);
                            Console.WriteLine();
                            PrintPerson(People[i]);
                            break;
                        default:
                            Console.WriteLine("Invalid Number:");
                            break;
                    }

                }
                
            }
            
            


        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

  
   
}
