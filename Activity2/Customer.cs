using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity2LB._2;
using Activity2LB;
using Activity2._1LB;



namespace Activity2
{
    class Customer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter address");
            string address=Console.ReadLine();

            int currentValueForCustomerId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter custemor id");
            int customerId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter custemor name");
            string customerName= Console.ReadLine();
            Console.WriteLine("enter custemor type");
            string customerType=Console.ReadLine();
            Console.WriteLine("enter data of birth");

            DateTime dateTime = new DateTime();
            Console.WriteLine(dateTime);
            Console.ReadKey();
            Console.WriteLine("email");
            string emailId=Console.ReadLine();
            Console.WriteLine("enter password");
            string password=Console.ReadLine();
           // Product pro = new Product(u.productName,u1.description,u.price);

            

            }

        }
    }
}
