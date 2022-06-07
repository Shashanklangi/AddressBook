
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
                            Console.WriteLine("2:To Display");
                            Console.WriteLine("3:To Edit");
                            Console.WriteLine("4:To Remove");
                            Console.WriteLine("5:To Search Person");
                            Console.WriteLine("6:To View by City Name");
                            Console.WriteLine("7:Count Person by City and State");
                            Console.WriteLine("8:Sort by Person Name");
                            Console.WriteLine("9:Sort by City Name");
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
                                        family.DisplayContacts();
                                        continue;
                                    case 3:
                                        family.Edit();
                                        continue;
                                    case 4:
                                        family.Remove();
                                        continue;
                                    case 5:
                                        Console.WriteLine("Enter city");
                                        string city = Console.ReadLine();
                                        family.SearchPerson(city);
                                        continue;
                                    case 6:
                                        Console.WriteLine("Enter state");
                                        string State = Console.ReadLine();
                                        family.ViewWithState(State);
                                        continue;
                                    case 7:
                                        family.Countperson();
                                        continue;
                                    case 8:
                                        family.SortByPersonName();
                                        continue;
                                    case 9:
                                        family.SortByCity();
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
                            Console.WriteLine("2:To Display");
                            Console.WriteLine("3:To Edit");
                            Console.WriteLine("4:To Remove");
                            Console.WriteLine("5:To Search Person");
                            Console.WriteLine("6:To View by City Name");
                            Console.WriteLine("7:Count Person by City and State");
                            Console.WriteLine("8:Sort by Person name");
                            Console.WriteLine("8:Sort by City name");
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
                                        friend.DisplayContacts();
                                        continue;
                                    case 3:
                                        friend.Edit();
                                        continue;
                                    case 4:
                                        friend.Remove();
                                        continue;
                                    case 5:
                                        Console.WriteLine("Enter city");
                                        string city = Console.ReadLine();
                                        friend.SearchPerson(city);
                                        continue;
                                    case 6:
                                        Console.WriteLine("Enter state");
                                        string State = Console.ReadLine();
                                        friend.ViewWithState(State);
                                        continue;
                                    case 7:
                                        friend.Countperson();
                                        continue;
                                    case 8:
                                        friend.SortByPersonName();
                                        continue;
                                    case 9:
                                        friend.SortByCity();
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

