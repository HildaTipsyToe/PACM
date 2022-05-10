namespace PACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
        }
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

        ///<summary> 
        /// Validates the customer data.
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