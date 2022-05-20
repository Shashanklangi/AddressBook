

namespace AddressBook
{
    public class Program
    {
        public void program()
        {

        }
        public static void Main(string[] args)
        {
            var list = new List<AddressBook>();
            AddressBook address = new AddressBook();

            Console.WriteLine(" Welcome to the Address Book ");

            Console.WriteLine("Enter the First Name: ");
            address.Firstname = Console.ReadLine();

            Console.WriteLine("Enter the Last Name: ");
            address.Lastname = Console.ReadLine();

            Console.WriteLine("Enter the City Name: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter the State Name: ");
            address.State = Console.ReadLine();

            Console.WriteLine("Enter the Email Name: ");
            address.Email = Console.ReadLine();

            Console.WriteLine("Enter the Address: ");
            address.Address = Console.ReadLine();

            Console.WriteLine("Enter the Zip Code: ");
            address.ZipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Phone Number: ");
            address.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            list.Add(address);
            Console.WriteLine("*****Details*****");
            Console.WriteLine("FirstName: " + address.Firstname);
            Console.WriteLine("LastName: " + address.Lastname);
            Console.WriteLine("City: " + address.City);
            Console.WriteLine("State: " + address.State);
            Console.WriteLine("Email: " + address.Email);
            Console.WriteLine("Address: " + address.Address);
            Console.WriteLine("ZipCode: " + address.ZipCode);
            Console.WriteLine("PhoneNumber: " + address.PhoneNumber);

        }


    }

}


