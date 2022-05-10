using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer class
            //pass in the requested id
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer

            //temporary hard-coded values to return
            //a populated customer
            if ( customerId == 1)
            {
                customer.EmailAdr = "fbaggins@hobbition.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            //Codes that saves the passed in customer
            return true;
        }
    }
}
