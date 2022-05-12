using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACME.Common;

namespace PACM.BL
{
    public class Order : EntitBase, ILoggable
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            orderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log() => $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {this.entityState.ToString()}";

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        ///<summary>
        /// Validates the orde data.
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
