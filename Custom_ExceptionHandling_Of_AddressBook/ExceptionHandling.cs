using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_ExceptionHandling_Of_AddressBook
{
    public class ExceptionHandling
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    class AddressBook
    {
        private ExceptionHandling[] entries;
        private int temp;


        public AddressBook()
        {
            entries = new ExceptionHandling[05];
            temp = 0;
        }


        public void AddDetails(ExceptionHandling entry)
        {
            if (temp < entries.Length)
            {
                entries[temp] = entry;
                temp++;
                Console.WriteLine("Entry added successfully.");
            }
            else
            {
                Console.WriteLine("Address book is full. Not able to add more entries.");
            }
        }

        public void EditDetails(string firstName)
        {
            try
            {
                if (EditDetails == null)
                {
                    throw new CustomException("Invalid Input");
                }
                bool entryFound = false;

                for (int i = 0; i <= temp; i++)
                {
                    if (entries[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Enter updated last name:");
                        entries[i].LastName = Console.ReadLine();

                        Console.WriteLine("Enter updated contact number:");
                        entries[i].ContactNumber = Console.ReadLine();

                        Console.WriteLine("Enter updated email name:");
                        entries[i].Email = Console.ReadLine();

                        Console.WriteLine("Enter updated city:");
                        entries[i].City = Console.ReadLine();

                        Console.WriteLine("Enter updated state:");
                        entries[i].State = Console.ReadLine();

                        Console.WriteLine("Entry updated successfully.");
                        entryFound = true;
                        break;
                    }
                }

                if (!entryFound)
                {
                    Console.WriteLine("Entry not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Custom Exception : " + ex.Message);
            }
        }

        public void ViewAllDetailsEntered()
        {
            if (temp == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }

            Console.WriteLine("All Entries");

            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine($"First Name: {entries[i].FirstName}");
                Console.WriteLine($"Last Name: {entries[i].LastName}");
                Console.WriteLine($"Contact Number: {entries[i].ContactNumber}");
                Console.WriteLine($"Email: {entries[i].Email}");
                Console.WriteLine($"City: {entries[i].City}");
                Console.WriteLine($"State: {entries[i].State}");
                Console.WriteLine();
            }
        }

        public void DeleteDetails(string firstName)
        {
            bool entryFound = false;

            for (int i = 0; i < temp; i++)
            {
                if (entries[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < temp - 1; j++)
                    {
                        entries[j] = entries[j + 1];
                    }

                    temp--;
                    Console.WriteLine("Entry delated successfully.");
                    entryFound = true;
                    break;
                }
            }

            if (!entryFound)
            {
                Console.WriteLine("Entry not found.");
            }
        }
    }
}
