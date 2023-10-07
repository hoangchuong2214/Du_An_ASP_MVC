namespace ShoppingCart.Models.ViewModels
{
    public class CartItemViewModel
    {
        public List<CartItemViewModel> CartItems { get;}
        public decimal GrandTotal { get; set; }
    }
}
