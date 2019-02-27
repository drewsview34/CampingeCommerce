using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public string UserID { get; set; }
        public decimal Subtotal { get; set; }

        public List<CartProduct> cartProducts { get; set; }


    }
}
