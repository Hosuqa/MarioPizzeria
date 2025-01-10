namespace MarioPizzeria.Data
{
    public static class SeedData
    {
        public static void Initialize(PizzaContext context)
        {
            if (!context.Pizzas.Any())
            {
                context.Pizzas.AddRange(
                    new Pizza
                    {
                        Nazwa = "Mario",
                        Koszt = 25.00M,
                        Skladniki = "Sos pomidorowy, mozzarella, bazylia"
                    },
                    new Pizza
                    {
                        Nazwa = "Luigi",
                        Koszt = 28.00M,
                        Skladniki = "Sos pomidorowy, mozzarella, pepperoni"
                    },
                    new Pizza
                    {
                        Nazwa = "Peach",
                        Koszt = 30.00M,
                        Skladniki = "Sos pomidorowy, mozzarella, szynka, pieczarki"
                    },
                    new Pizza
                    {
                        Nazwa = "Bowser",
                        Koszt = 28.00M,
                        Skladniki = "Sos pomidorowy, mozzarella, szynka, ananas"
                    },
                    new Pizza
                    {
                        Nazwa = "Toad",
                        Koszt = 32.00M,
                        Skladniki = "Sos pomidorowy, mozzarella, salami pikantne, papryka jalapeno"
                    },
                    new Pizza
                    {
                        Nazwa = "Wario",
                        Koszt = 29.00M,
                        Skladniki = "Sos pomidorowy, mozzarella, pieczarki, papryka, cebula, oliwki"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}