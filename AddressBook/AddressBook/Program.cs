
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
                switch (option)
                {
                    case 1:
                        FamilyDetails family = new FamilyDetails();
                       
                        do
                        {
                            Console.WriteLine("\n1:To Add a Contact");
                            Console.WriteLine("2:To Edit Contacts");
                            Console.WriteLine("3:To Remove a contact");
                            Console.WriteLine("0:To Exit");
                            {
                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        FamilyDetails contact = new FamilyDetails();
                                        contact.GetInfo();
                                        continue;
                                    case 2:
                                        FamilyDetails edit = new FamilyDetails();
                                        edit.Edit();
                                        break;
                                    case 3:
                                        FamilyDetails remove = new FamilyDetails();
                                        remove.Remove();
                                        break;
                                    default:
                                        Console.WriteLine("Have a Nice Day");
                                        break;
                                }
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
                            {
                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        FriendsDetails contact = new FriendsDetails();
                                        contact.GetInfo();
                                        continue;
                                    case 2:
                                        FriendsDetails edit = new FriendsDetails();
                                        edit.Edit();
                                        break;
                                    case 3:
                                        FriendsDetails remove = new FriendsDetails();
                                        remove.Remove();
                                        break;
                                    default:
                                        Console.WriteLine("Have a Nice Day");
                                        break;
                                }
                            }
                        }
                        while (option != 0);
                        break;

                    case 3:

                        OfficeDetails office = new OfficeDetails();

                        do
                        {
                            Console.WriteLine("\n1:To Add a Contact");
                            Console.WriteLine("2:To Edit Contacts");
                            Console.WriteLine("3:To Remove a contact");
                            Console.WriteLine("0:To Exit");
                            {
                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        OfficeDetails contact = new OfficeDetails();
                                        contact.GetInfo();
                                        continue;
                                    case 2:
                                        OfficeDetails edit = new OfficeDetails();
                                        edit.Edit();
                                        break;
                                    case 3:
                                        OfficeDetails remove = new OfficeDetails();
                                        remove.Remove();
                                        break;
                                    default:
                                        Console.WriteLine("Have a Nice Day");
                                        break;
                                }
                            }
                        }
                        while (option != 0);
                        break;


                }

            }

        }  
    }
}


