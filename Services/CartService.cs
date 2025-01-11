using System.Collections.Generic;

namespace MarioPizzeria.Services
{
    public class CartService
    {
        public List<CartItem> Items { get; private set; } = new List<CartItem>();

        public void AddToCart(int pizzaId, string name, string description, int quantity, float price)
        {
            var existingItem = Items.Find(item => item.PizzaId == pizzaId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.TotalPrice += quantity * price;
            }
            else
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
    }

    public class CartItem
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }

    }
}
