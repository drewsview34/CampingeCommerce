
using Camping.Model.ProductModel;

namespace Camping.Models
{
    public class CartProduct
    {
        public int CartProductId { get; set; }
        public int CartID { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        //I dont know if we want to rename our class inventory rather than product because that makes a whole lot sense.
        public Product Product { get; set; }
    }
}