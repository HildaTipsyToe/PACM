namespace PACM.BL
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string EmailAdr { get; set; }
        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!String.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ",";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        ///<Summary>
        ///Retrieve all customers.
        ///</summary>
        ///<param name="CustomeriD"></param>
        ///<Returns></Returns>
        public List<Customer> Retrieve()
        {
            //code that retrueves al of the customers.
            return new List<Customer>();
        }

        ///<Summary>
        ///Retrieve one customer.
        ///</summary>
        ///<Returns></Returns>
        public Customer Retrieve(int customerId)
        {
            //code that retrueves the defined customer
            return new Customer();
        }

        ///<Summary>
        ///Saves the current customer
        ///</Summary>
        ///<Returns></Returns>
        public bool Save()
        {
            //Code that saves the defined customer
            return true;
        }
        
        ///<Summary>
        ///Validates the customer data.
        ///</summary>
        ///<Returns></Returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdr)) isValid = false;
            return isValid;
        }
    }
}