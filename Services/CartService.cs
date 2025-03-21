namespace MarioPizzeria.Services
{
    public class CartService
    {
        public List<CartItem> Items { get; private set; } = new List<CartItem>();

        public void AddToCart(int pizzaId, string name, string description, int quantity, float price)
        {//sprawdzenie czy produkt już jest w koszyku
            var existingItem = Items.Find(item => item.PizzaId == pizzaId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.TotalPrice += quantity * price;
            }
            else//dodać nowy produkt do koszyka
            {
                Items.Add(new CartItem
                {
                    PizzaId = pizzaId,
                    Name = name,
                    Description = description,
                    Quantity = quantity,
                    TotalPrice = quantity * price,
                });
            }
        }
        public void ClearCart()
        {
            Items.Clear();
        }
        public float GetTotalPrice()
        {
            return Items.Sum(item => item.TotalPrice);
        }
        //usuwanie z koszyka
        public void RemoveFromCart(int pizzaId)
        {
            var itemToRemove = Items.Find(item => item.PizzaId == pizzaId);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }
        public void IncreaseQuantity(int pizzaId)
        {
            var item = Items.Find(i => i.PizzaId == pizzaId);
            if (item != null)
            {
                item.Quantity++;
                item.TotalPrice = item.Quantity * (item.TotalPrice / (item.Quantity - 1)); // Przeliczenie ceny
            }
        }

        public void DecreaseQuantity(int pizzaId)
        {
            var item = Items.Find(i => i.PizzaId == pizzaId);
            if (item != null && item.Quantity > 1)
            {
                item.Quantity--;
                item.TotalPrice = item.Quantity * (item.TotalPrice / (item.Quantity + 1)); // Przeliczenie ceny
            }
            else
            {
                RemoveFromCart(pizzaId); // Usunięcie, jeśli ilość spadnie do 0
            }
        }
    }

    public class CartItem
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }

    }
}
