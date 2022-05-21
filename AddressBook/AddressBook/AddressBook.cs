using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class ContactDetails
    {
        ArrayList list = new ArrayList();
        public void AddDetails()
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
    }
}
       

            

        

