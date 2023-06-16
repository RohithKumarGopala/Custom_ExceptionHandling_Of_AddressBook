namespace Custom_ExceptionHandling_Of_AddressBook
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBookProblem = new AddressBook();


            while (true)
            {
                Console.WriteLine("Address Book Menu");
                Console.WriteLine("1. Add Details");
                Console.WriteLine("2. Edit Details");
                Console.WriteLine("3. View Entered Details");
                Console.WriteLine("4. Delete Details");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice (1-5):");

                try
                {

                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 6)
                    {
                        throw new CustomException("Invalid Input");
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first name");
                            string firstName = Console.ReadLine();

                            Console.WriteLine("Enter last name:");
                            string lastName = Console.ReadLine();

                            Console.WriteLine("Enter ContactNumber");
                            string contactnumber = Console.ReadLine();

                            Console.WriteLine("Enter Email");
                            string email = Console.ReadLine();

                            Console.WriteLine("Enter City");
                            string city = Console.ReadLine();

                            Console.WriteLine("Enter State");
                            string state = Console.ReadLine();

                            ExceptionHandling entry = new ExceptionHandling
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                ContactNumber = contactnumber,
                                Email = email,
                                City = city,
                                State = state,
                            };
                            addressBookProblem.AddDetails(entry);
                            break;
                        case 2:
                            Console.WriteLine("Enter first name of the entry to edit:");
                            string editFirstName = Console.ReadLine();
                            addressBookProblem.EditDetails(editFirstName);
                            break;

                        case 3:
                            addressBookProblem.ViewAllDetailsEntered();
                            break;

                        case 4:
                            Console.WriteLine("Enter first name of the entry to delete:");
                            string deleteFirstName = Console.ReadLine();
                            addressBookProblem.DeleteDetails(deleteFirstName);
                            break;

                        case 5:
                            Console.WriteLine("Exiting program.");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }

                catch (CustomException ex)
                {
                    Console.WriteLine("Invalid Input please enter between 1-5 ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("General Exception caught:" + ex.Message);
                }

                Console.WriteLine();
            }
        }
    }
}