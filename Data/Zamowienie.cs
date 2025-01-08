namespace MarioPizzeria.Data
{
    
    public class Zamowienie
    {
        public ICollection<ZamowionePizze> ZamowionePizze { get; set; }
        public int Id { get; set; }
        public string Imie { get; set; } = string.Empty;
        public string Adres { get; set; } = string.Empty;
        public string? Uwagi { get; set; }
    }
}