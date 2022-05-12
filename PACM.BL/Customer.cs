using PACME.Common;

namespace PACM.BL
{
    public class Customer : EntitBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerID { get; private set; }
        public int CustomerType { get; private set; }
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
        public override string ToString() => FullName;

        public string Log() => $"{CustomerID}: {FullName} Email: {EmailAdr} Status: {entityState.ToString()}";
        

        ///<summary> 
        /// Validates the customer data.
        ///</summary>
        ///<Returns></Returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdr)) isValid = false;
            return isValid;
        }
    }
}