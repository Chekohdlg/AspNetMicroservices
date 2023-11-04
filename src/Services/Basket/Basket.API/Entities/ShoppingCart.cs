namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string userName { get; set; }
        public List<ShoppingCartItem> items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {
            
        }

        public ShoppingCart(string userName)
        {
            userName = userName ?? string.Empty; 
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in items)
                {
                    totalPrice += item.Price;
                }
                //items.Sum(x=> x.Price);// better?
                return totalPrice;
            } 
        }

    }
}
