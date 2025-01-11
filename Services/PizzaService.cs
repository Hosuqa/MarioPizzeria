using MarioPizzeria.Models;

namespace MarioPizzeria.Services
{
    public class PizzaService
    {
        private readonly List<Pizza> _pizzas = new()
        {
            new Pizza { Id = 1, Name = "Mario", Description = "Klasyczna pizza z sosem pomidorowym i serem.", BasePrice = 25.99f },
            new Pizza { Id = 2, Name = "Luigi", Description = "Pikantne salami, oregano, sos pomidorowy i ser.", BasePrice = 29.99f },
            new Pizza { Id = 3, Name = "Bowser", Description = "Szynka, pieczarki, oliwki, sos pomidorowy i ser.", BasePrice = 32.99f },
            new Pizza { Id = 4, Name = "Peach", Description = "Szynka, ananas, sos pomidorowy i ser.", BasePrice = 32.99f },
            new Pizza { Id = 5, Name = "Wario", Description = "Szynka, jalapeño, cebula, sos pomidorowy i ser.", BasePrice = 32.99f },
            new Pizza { Id = 6, Name = "Waluigi", Description = "Ser cheddar, świeża mozzarella, ser corregio, sos czosnkowy.", BasePrice = 32.99f },

        };

        public Task<List<Pizza>> GetPizzasAsync()
        {
            return Task.FromResult(_pizzas);
        }
    }
}
