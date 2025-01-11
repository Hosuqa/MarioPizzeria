using MarioPizzeria.Models;

namespace MarioPizzeria.Services
{
    public class PizzaService
    {
        private readonly List<Pizza> _pizzas = new()
        {
            new Pizza { Id = 1, Name = "Margherita", Description = "Klasyczna pizza z sosem pomidorowym i mozzarellą.", Price = 25.99M },
            new Pizza { Id = 2, Name = "Pepperoni", Description = "Pikantne salami na cienkim cieście.", Price = 29.99M },
            new Pizza { Id = 3, Name = "Capricciosa", Description = "Szynka, pieczarki, karczochy i oliwki.", Price = 32.99M },
            new Pizza { Id = 3, Name = "Capricciosa", Description = "Szynka, pieczarki, karczochy i oliwki.", Price = 32.99M }

        };

        public Task<List<Pizza>> GetPizzasAsync()
        {
            return Task.FromResult(_pizzas);
        }
    }
}
