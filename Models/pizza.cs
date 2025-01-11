namespace MarioPizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float BasePrice { get; set; }
        public string ImageUrl { get; set; } 
    }
}
