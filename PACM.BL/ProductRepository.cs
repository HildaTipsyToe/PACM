using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create the instance of the product class.
            // Pass in the requested Id
            Product product = new Product(productId);

            // Code that retrieves the defined product

            // Temporary hard-coded values to return
            // a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        public bool Save (Product product)
        {
            //Code that saves the passed in product
            return true;
        }
    }
}
