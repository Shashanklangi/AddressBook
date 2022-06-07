using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class FamilyDetails
    {
        ArrayList contact = new ArrayList();
        List<ContactDetails> list = new List<ContactDetails>();
        public void GetInfo()
        {
            Console.WriteLine("How many person Contact Detail You want to add:");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("\nAdd details of the person: " + i);

                Console.WriteLine("Enter your First name");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                string LastName = Console.ReadLine();
                Console.WriteLine("Enter your Email ID");
                string EmailID = Console.ReadLine();
                Console.WriteLine("Enter your Address");
                string Address = Console.ReadLine();
                Console.WriteLine("Enter your city name");
                string City = Console.ReadLine();
                Console.WriteLine("Enter your state name");
                string State = Console.ReadLine();
                Console.WriteLine("Enter your ZIP number");
                string ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your phone number");
                string PhoneNumber = Console.ReadLine();

                ContactDetails contacts = new ContactDetails(FirstName, LastName, Address, City, State, EmailID, ZipCode, PhoneNumber);
                list.Add(contacts);
                contact.Add(FirstName);
                contact.Add(LastName);
                contact.Add(Address);
                contact.Add(City);
                contact.Add(State);
                contact.Add(EmailID);
                contact.Add(ZipCode);
                contact.Add(PhoneNumber);
            }
        }
        public void DisplayContacts()
        {
            int j = 0;
            int count = 1;
            foreach (var item in contact)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("\nNumber of person :" + count);
                    Console.WriteLine("FirstName: " + contact[j]);
                    Console.WriteLine("LastName: " + contact[j + 1]);
                    Console.WriteLine("Address : " + contact[j + 2]);
                    Console.WriteLine("City: " + contact[j + 3]);
                    Console.WriteLine("State: " + contact[j + 4]);
                    Console.WriteLine("Email: " + contact[j + 5]);
                    Console.WriteLine("ZipCode: " + contact[j + 6]);
                    Console.WriteLine("Phone Number: " + contact[j + 7]);
                    count++;
                }
                j++;
            }
        }
        public void Edit()
        {
            Console.WriteLine("\nEnter the FirstName whose data you want to change");
            string First_Name = Console.ReadLine();
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
                            contact[i] = FirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter your correct Last name");
                            string LastName = Console.ReadLine();
                            contact[i + 1] = LastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter your correct Email ID");
                            string EmailID = Console.ReadLine();
                            contact[i + 2] = EmailID;
                            break;
                        case 4:
                            Console.WriteLine("Enter your correct Address");
                            string Address = Console.ReadLine();
                            contact[i + 3] = Address;
                            break;
                        case 5:
                            Console.WriteLine("Enter your correct City name");
                            string City = Console.ReadLine();
                            contact[i + 4] = City;
                            break;
                        case 6:
                            Console.WriteLine("Enter your correct State name");
                            string State = Console.ReadLine();
                            contact[i + 5] = State;
                            break;
                        case 7:
                            Console.WriteLine("Enter your correct Zip_Code");
                            string Zip_Code = Console.ReadLine();
                            contact[i + 6] = Zip_Code;
                            break;
                        case 8:
                            Console.WriteLine("Enter your correct PhoneNumber");
                            string PhoneNumber = Console.ReadLine();
                            contact[i + 7] = PhoneNumber;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                }
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
        }
        public void SearchPerson(string city)
        {
            var result = list.FindAll(x => x.City == city);
            foreach (var item in list)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " + 
                                    "\nEmail ID :" + item.EmailId + " " + "\nAddress :" + item.Address + " " +
                                    "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                    "\nZip Code :" + item.Zipcode + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
        public void ViewWithState(string State)
        {
            var result = list.FindAll(r => r.State == State);
            Console.WriteLine("Details of people who live in state :");
            foreach (var item in result)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                    "\nEmail ID :" + item.EmailId + " " + "\nAddress :" + item.Address + " " +
                                    "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                    "\nZip Code :" + item.Zipcode + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-----------------------------------------------------------");
            }
        }
        public void Countperson()
        {
            Console.WriteLine("Count Person-City and state wise:");
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter state");
            string State = Console.ReadLine();
            var result = list.FindAll(r => (r.City == City && r.State == State));
            foreach (var item in result)
            {
                Console.WriteLine("First Name :" + item.FirstName + " " + "\nLast Name :" + item.LastName + " " +
                                    "\nEmail ID :" + item.EmailId + " " + "\nAddress :" + item.Address + " " +
                                    "\nCity Name :" + item.City + " " + "\nState Name :" + item.State + " " +
                                    "\nZip Code :" + item.Zipcode + " " + "\nPhoneNumber :" + item.PhoneNumber);
                Console.WriteLine("-----------------------------------------------------------");
            }
            var results = result.Count;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Total Persons in City: {City} & State: {State}: are " + results);
        }
        public void SortByPersonName()
        {
            var Sort = list.OrderBy(r => r.FirstName).ToList();
            foreach (var item in Sort)
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




