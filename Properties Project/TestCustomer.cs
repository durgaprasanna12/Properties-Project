using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Project
{
        class TestCustomer
        {
            static void Main()
            {
                Customer obj = new Customer(101, false, "John", 5000.0,Cities.Begaluru,"Karnataka"," INDIA");
                Console.WriteLine("Customer ID " + obj.CustID);

                //obj.CustID = 102; // Cant assigned as the property is read only if we dont set the value
                obj.CustID = 102; //here we set the value
                Console.WriteLine("Modified Customer ID : " + obj.CustID);
                if (obj.Status == true)
                {
                    Console.WriteLine("Current customer status : active");
                }
                else
                {
                    Console.WriteLine("Current customer status : In-Active");
                }
                Console.WriteLine("Customer Name : " + obj.Cname);
                obj.Cname += " Smith";
                Console.WriteLine("Modified Customer Name : " + obj.Cname); //assigned failed . so below smith wont be added to the name as the status is false
                Console.WriteLine("Customer Balance : " + obj.Balance);
                obj.Balance -= 3000.0;
                Console.WriteLine("Modified Customer Balance : " + obj.Balance); //assigned failed . so below 1000 wont be deducted from the balance as the status is false

                obj.Status = true; // here we set the status to true so that we can modify the name and balance
                Console.WriteLine("----------");
                if (obj.Status == true)
                {
                    Console.WriteLine("Current customer status : active");
                }
                else
                {
                    Console.WriteLine("Current customer status : In-Active");
                }

                obj.Cname += " Smith";
                Console.WriteLine("Modified Customer Name : " + obj.Cname); //assigned success . so below smith will be added to the name as the status is true


                obj.Balance -= 3000.0;
                Console.WriteLine("Modified Customer Balance : " + obj.Balance); //assigned success . so below 1000 will be deducted from the balance as the status is true
                Console.ReadLine();
                obj.Balance = obj.Balance - 1600; //Assignment fails, so prints old balance
                Console.WriteLine(" balance when assignment fails : " + obj.Balance);

                obj.Balance = obj.Balance - 1400; //Assignment Succeeds, so prints new balance
                Console.WriteLine(" balance when assignment succeeds : " + obj.Balance);

            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("Current City: " + obj.City);
            obj.City = Cities.Hyderabad;
            Console.WriteLine("Modified city: " + obj.City);

            Console.WriteLine("Current state : " + obj.State);
            // obj.State = "Telangana"; //Invalid beacuase current class is not a child class of Customer
            Console.WriteLine("Modified state: " + obj.State);

            Console.WriteLine(" Country : " + obj.Country);

            /*&Console.WriteLine("Current City" + obj.City);
            obj.City = "Pune";
            Console.WriteLine("Modified City : " + obj.City); //assigned success . so below city will be modified to pune as the status is true and city is in the list of allowed cities
             obj.City = "Delhi";
            Console.WriteLine("Modified City : " + obj.City); //assigned failed . so below city will not be modified to delhi as the status is true but city is not in the list of allowed cities
            Console.ReadLine();*/
        }
        }
    }

  

