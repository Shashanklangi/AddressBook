using Google.Protobuf.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class FriendsDetails
    {
        ArrayList list = new ArrayList();
        List<ContactDetails> lists = new List<ContactDetails>();
        public void GetInfo()
        {
            Console.WriteLine("How many person Contact Detail You want to add:");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("\nAdd details of the person: " + i);

                Console.WriteLine("Enter your First name");
                string First_Name = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                string Last_Name = Console.ReadLine();
                Console.WriteLine("Enter your Email ID");
                string EmailID = Console.ReadLine();
                Console.WriteLine("Enter your Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter your city name");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your state name");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your ZIP number");
                string Zip_Code = Console.ReadLine();
                Console.WriteLine("Enter your phone number");
                string PhoneNumber = Console.ReadLine();

                ContactDetails contactDetails = new ContactDetails(First_Name, Last_Name, Address, City, State, Zip_Code, PhoneNumber, EmailID);
                lists.Add(contactDetails);

                list.Add(First_Name);
                list.Add(Last_Name);
                list.Add(EmailID);
                list.Add(Address);
                list.Add(City);
                list.Add(State);
                list.Add(Zip_Code);
                list.Add(PhoneNumber);
            }
            int j = 0;
            int count = 1;
            foreach (var item in list)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + list[j]);
                    Console.WriteLine("Last Name: " + list[j + 1]);
                    Console.WriteLine("EmailID : " + list[j + 2]);
                    Console.WriteLine("Address : " + list[j + 3]);
                    Console.WriteLine("City : " + list[j + 4]);
                    Console.WriteLine("State :" + list[j + 5]);
                    Console.WriteLine("Zip_Code :" + list[j + 6]);
                    Console.Write("PhoneNumber :" + list[j + 7]);
                    count++;
                }
                j++;
            }
        }
        public void Edit()
        {
            Console.WriteLine("\nEnter the FirstName whose data you want to change");
            string First_Name = Console.ReadLine();
            Console.WriteLine("\nEnter the LasttName whose data you want to change");
            string Last_Name = Console.ReadLine();
            for (int i = 0; i < list.Count; i += 8)
            {
                if ((String.Equals(First_Name, (list[i]))))
                {
                    Console.WriteLine("Name:" + list + "==" + list[i]);
                    Console.WriteLine("Press 1: for First name");
                    Console.WriteLine("Press 2: for Last name");
                    Console.WriteLine("Press 3: for Email ID");
                    Console.WriteLine("Press 4: for Address");
                    Console.WriteLine("Press 5: for City name");
                    Console.WriteLine("Press 6: for State name");
                    Console.WriteLine("Press 7: for Zip_Code");
                    Console.WriteLine("Press 8: for PhoneNumber");
                    int check = Convert.ToInt32(Console.ReadLine());
                    switch (check)
                    {
                        case 1:
                            Console.WriteLine("Enter your correct First name");
                            string FirstName = Console.ReadLine();
                            list[i] = FirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter your correct Last name");
                            string LastName = Console.ReadLine();
                            list[i + 1] = LastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter your correct Email ID");
                            string EmailID = Console.ReadLine();
                            list[i + 2] = EmailID;
                            break;
                        case 4:
                            Console.WriteLine("Enter your correct Address");
                            string Address = Console.ReadLine();
                            list[i + 3] = Address;
                            break;
                        case 5:
                            Console.WriteLine("Enter your correct City name");
                            string City = Console.ReadLine();
                            list[i + 4] = City;
                            break;
                        case 6:
                            Console.WriteLine("Enter your correct State name");
                            string State = Console.ReadLine();
                            list[i + 5] = State;
                            break;
                        case 7:
                            Console.WriteLine("Enter your correct Zip_Code");
                            string Zip_Code = Console.ReadLine();
                            list[i + 6] = Zip_Code;
                            break;
                        case 8:
                            Console.WriteLine("Enter your correct PhoneNumber");
                            string PhoneNumber = Console.ReadLine();
                            list[i + 7] = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                }
            }
            int j = 0;
            int count = 1;
            foreach (var item in list)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\nAfter editing the datas are:");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + list[j]);
                    Console.WriteLine("Last Name: " + list[j + 1]);
                    Console.Write("Email ID:" + list[j + 2]);
                    Console.Write("Address:" + list[j + 3]);
                    Console.WriteLine("City Name: " + list[j + 4]);
                    Console.WriteLine("State Name: " + list[j + 5]);
                    Console.WriteLine("ZIP Number:" + list[j + 6]);
                    Console.WriteLine("Phone Number:" + list[j + 7]);
                    count++;
                }
                j++;
            }
        }
        public void Remove()
        {
            Console.WriteLine("\nEnter the FirstName whose data you want to remove");
            string First_Name = Console.ReadLine();
            for (int i = 0; i < list.Count; i += 8)
            {
                if ((String.Equals(First_Name, (list[i]))))
                {
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                }
            }
            int j = 0;
            int count = 1;
            foreach (var item in list)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\nAfter editing the datas are:");
                    Console.WriteLine("\nAddress of person: " + count);
                    Console.WriteLine("First Name: " + list[j]);
                    Console.WriteLine("Last Name: " + list[j + 1]);
                    Console.Write("Email ID:" + list[j + 2]);
                    Console.Write("Address:" + list[j + 3]);
                    Console.WriteLine("City Name: " + list[j + 4]);
                    Console.WriteLine("State Name: " + list[j + 5]);
                    Console.WriteLine("ZIP Number:" + list[j + 6]);
                    Console.WriteLine("Phone Number:" + list[j + 7]);
                    count++;
                }
                j++;
            }
        }
        public void SearchPerson(string city)
        {
            var result = lists.FindAll(x => x.City == city);
            foreach (var item in lists)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                    "\nEmail ID :" + item.EmailId + " " + "\nAddress :" + item.Address + " " +
                                    "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                    "\nZip Code :" + item.Zipcode + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
    }
}





