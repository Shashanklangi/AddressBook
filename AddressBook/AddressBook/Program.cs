
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("WelCome To The Address Book");
                Console.WriteLine("Select The Option For The Particular Address Book");
                Console.WriteLine("1: For the Family.");
                Console.WriteLine("2: For the Friends.");
                Console.WriteLine("3: For the Office.");

                int option = Convert.ToInt32(Console.ReadLine());
                Program details = new Program();
                int select = 0;
                switch (option)
                {
                    case 1:
                        FamilyDetails family = new FamilyDetails();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Contact");
                            Console.WriteLine("2:To Edit Contacts");
                            Console.WriteLine("3:To Remove a contact");
                            Console.WriteLine("4:To Search Person");                 
                            Console.WriteLine("0:To Exit");
                            int select1 = Convert.ToInt32(Console.ReadLine());
                            {
                                switch (select1)
                                {
                                    case 0:
                                        select = 1;
                                        break;
                                    case 1:
                                        family.GetInfo();
                                        continue;
                                    case 2:
                                        family.Edit();
                                        continue;
                                    case 3:
                                        family.Remove();
                                        continue;
                                    case 4:
                                        Console.WriteLine("Enter city");
                                        string city = Console.ReadLine();
                                        family.SearchPerson(city);
                                        break;
                                    default:
                                        Console.WriteLine("Have a Nice Day");
                                        break;
                                }
                                if (select == 1) ;
                                break;
                            }
                        }
                        while (option != 0);
                        break;

                    case 2:
                        FriendsDetails friend = new FriendsDetails();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Contact");
                            Console.WriteLine("2:To Edit Contacts");
                            Console.WriteLine("3:To Remove a contact");
                            Console.WriteLine("0:To Exit");
                            int select2 = Convert.ToInt32(Console.ReadLine());
                            {
                                switch (select2)
                                {
                                    case 0:
                                        select = 1;
                                        break;
                                    case 1:
                                        friend.GetInfo();
                                        continue;
                                    case 2:
                                        friend.Edit();
                                        continue;
                                    case 3:
                                        friend.Remove();
                                        continue;
                                    case 4:
                                        Console.WriteLine("Enter city");
                                        string city = Console.ReadLine();
                                        friend.SearchPerson(city);
                                        break;
                                    default:
                                        Console.WriteLine("Have a Nice Day");
                                        break;
                                }
                                if (select == 1) ;
                                break;
                            }
                        }
                        while (option != 0);
                        break;
                    
                }

            }

        }
    }
}

