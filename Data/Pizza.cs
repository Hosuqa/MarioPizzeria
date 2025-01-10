namespace MarioPizzeria.Data
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nazwa { get; set; } = string.Empty;
        public string Skladniki { get; set; } = string.Empty;
        public decimal Koszt { get; set; }
        public ICollection<ZamowionePizze> ZamowionePizze { get; set; } = new List<ZamowionePizze>();
    }
}