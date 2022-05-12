using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACME.Common;

namespace PACM.BL
{
    public class Product : EntitBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            productId = ProductId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        private string _productName;

        public string ProductName
        {
            get {
                //return StringHandler.InsertSpaces(_productName);
                return _productName.InsertSpaces();
                }
            set { _productName = value; }
        }

        public override string ToString() => ProductName;
        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {entityState.ToString()}";

        ///<summary>
        /// Validates the product data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            
            if(string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if(CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
