using MarioPizzeria.Data;

namespace MarioPizzeria.Data
{
    public class ZamowionePizze
    {
        public int Id { get; set; }
        public int IdPizzy { get; set; }
        public int IdZamowienia { get; set; }
        public int Ilosc { get; set; }
        public Pizza Pizza { get; set; }
        public Zamowienie Zamowienie { get; set; }
    }
}